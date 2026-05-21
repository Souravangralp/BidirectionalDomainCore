using Org.BouncyCastle.Asn1.Sec;
using Org.BouncyCastle.Asn1.X9;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Agreement;
using Org.BouncyCastle.Crypto.Digests;
using Org.BouncyCastle.Crypto.Engines;
using Org.BouncyCastle.Crypto.Generators;
using Org.BouncyCastle.Crypto.Macs;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Math.EC;
using Org.BouncyCastle.OpenSsl;
using Org.BouncyCastle.Security;
using System.Text;

namespace Bidirectional.DomainCore.BidOnboard.Infrastructure.Onboarding.Common;

public static class ECCIESHelper
{
    public static ECPublicKeyParameters? PublicKey { get; set; }

    public static ECPrivateKeyParameters? PrivateKey { get; set; }

    private static readonly X9ECParameters EcParams = SecNamedCurves.GetByName("secp256r1");

    public static void LoadKeysFromBase64(string publicKeyBase64Pem, string privateKeyBase64Pem)
    {
        // --- Public Key ---
        // Decode Base64 -> PEM string
        string publicPem = Encoding.UTF8.GetString(Convert.FromBase64String(publicKeyBase64Pem));

        using StringReader pubReader = new StringReader(publicPem);
        object pubObj = new PemReader(pubReader).ReadObject();
        if (pubObj is ECPublicKeyParameters pubKey)
        {
            PublicKey = pubKey;
        }
        else
        {
            throw new InvalidOperationException("Invalid public key format.");
        }

        // --- Private Key ---
        string privatePem = Encoding.UTF8.GetString(Convert.FromBase64String(privateKeyBase64Pem));

        using StringReader privReader = new StringReader(privatePem);
        object privObj = new PemReader(privReader).ReadObject();

        if (privObj is AsymmetricCipherKeyPair keyPair)
        {
            PrivateKey = (ECPrivateKeyParameters)keyPair.Private;
        }
        else if (privObj is ECPrivateKeyParameters ecPriv)
        {
            PrivateKey = ecPriv;
        }
        else
        {
            throw new InvalidOperationException("Invalid private key format.");
        }
    }

    public static (string privateKeyBase64Pem, string publicKeyBase64Pem) GenerateKeyPair()
    {
        ECKeyPairGenerator gen = new ECKeyPairGenerator();
        X9ECParameters namedCurve = ECNamedCurveTable.GetByName("secp256r1");
        gen.Init(new ECKeyGenerationParameters(new ECDomainParameters(namedCurve.Curve, namedCurve.G, namedCurve.N, namedCurve.H), new SecureRandom()));
        AsymmetricCipherKeyPair keyPair = gen.GenerateKeyPair();

        string privatePem, publicPem;
        using (StringWriter sw = new StringWriter())
        {
            PemWriter pemWriter = new PemWriter(sw);
            pemWriter.WriteObject(keyPair.Private);
            pemWriter.Writer.Flush();
            privatePem = sw.ToString();
        }

        using (StringWriter sw = new StringWriter())
        {
            PemWriter pemWriter = new PemWriter(sw);
            pemWriter.WriteObject(keyPair.Public);
            pemWriter.Writer.Flush();
            publicPem = sw.ToString();
        }

        // Encode the PEM text itself into Base64
        string privateKeyBase64Pem = Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(privatePem));
        string publicKeyBase64Pem = Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(publicPem));

        return (privateKeyBase64Pem, publicKeyBase64Pem);
    }

    //public static (string privateKeyBase64, string publicKeyBase64) GenerateKeyPair()
    //{
    //    var gen = new ECKeyPairGenerator();
    //    gen.Init(new ECKeyGenerationParameters(domainParams, new SecureRandom()));
    //    var keyPair = gen.GenerateKeyPair();

    //    var privateKeyParams = (ECPrivateKeyParameters)keyPair.Private;
    //    var publicKeyParams = (ECPublicKeyParameters)keyPair.Public;

    //    // Convert private key (D) to Base64
    //    var privateKeyBytes = privateKeyParams.D.ToByteArrayUnsigned();
    //    var privateKeyBase64 = Convert.ToBase64String(privateKeyBytes);

    //    // Convert public key (Q) to Base64 (uncompressed format)
    //    var publicKeyBytes = publicKeyParams.Q.GetEncoded(false);
    //    var publicKeyBase64 = Convert.ToBase64String(publicKeyBytes);

    //    return (privateKeyBase64, publicKeyBase64);
    //}

    public static string Encrypt(string data)
    {
        SecureRandom random = new SecureRandom();
        ECKeyPairGenerator keyGen = new ECKeyPairGenerator();
        keyGen.Init(new ECKeyGenerationParameters(PublicKey?.Parameters, random));
        AsymmetricCipherKeyPair ephKeyPair = keyGen.GenerateKeyPair();

        IesEngine engine = new IesEngine(
            new ECDHBasicAgreement(),
            new Kdf2BytesGenerator(new Sha256Digest()),
            new HMac(new Sha256Digest()));

        IesWithCipherParameters parameters = new IesWithCipherParameters(new byte[0], new byte[0], 128, 256);
        engine.Init(true, ephKeyPair.Private, PublicKey, parameters);

        byte[] plaintext = Encoding.UTF8.GetBytes(data);
        byte[] cipherText = engine.ProcessBlock(plaintext, 0, plaintext.Length);

        // Ephemeral public key as raw uncompressed point (65 bytes)
        byte[] ephPub = ((ECPublicKeyParameters)ephKeyPair.Public).Q.GetEncoded(false);
        byte[] lenPrefix = { (byte)(ephPub.Length >> 8), (byte)(ephPub.Length & 0xFF) };

        byte[] output = new byte[2 + ephPub.Length + cipherText.Length];
        Buffer.BlockCopy(lenPrefix, 0, output, 0, 2);
        Buffer.BlockCopy(ephPub, 0, output, 2, ephPub.Length);
        Buffer.BlockCopy(cipherText, 0, output, 2 + ephPub.Length, cipherText.Length);

        return Convert.ToBase64String(output);
    }

    public static string Decrypt(string encrypted)
    {
        byte[] input = Convert.FromBase64String(encrypted);
        if (input.Length < 2)
            throw new ArgumentException("Invalid input length.");

        int ephLen = input[0] << 8 | input[1];
        if (input.Length < 2 + ephLen)
            throw new ArgumentException("Invalid input: missing ciphertext.");

        byte[] ephPubBytes = new byte[ephLen];
        Buffer.BlockCopy(input, 2, ephPubBytes, 0, ephLen);
        byte[] cipherText = new byte[input.Length - 2 - ephLen];
        Buffer.BlockCopy(input, 2 + ephLen, cipherText, 0, cipherText.Length);

        ECPoint q = EcParams.Curve.DecodePoint(ephPubBytes);
        ECPublicKeyParameters ephPubKey = new ECPublicKeyParameters(q, PrivateKey?.Parameters);

        IesEngine engine = new IesEngine(
            new ECDHBasicAgreement(),
            new Kdf2BytesGenerator(new Sha256Digest()),
            new HMac(new Sha256Digest()));

        IesWithCipherParameters parameters = new IesWithCipherParameters(new byte[0], new byte[0], 128, 256);
        engine.Init(false, PrivateKey, ephPubKey, parameters);

        byte[] decrypted = engine.ProcessBlock(cipherText, 0, cipherText.Length);
        return Encoding.UTF8.GetString(decrypted);
    }
}

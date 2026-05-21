using System.Security.Cryptography;
using System.Text;

namespace Bidirectional.Application.Common;

public static class EncryptDecryptData
{
    public static string EncryptWithKey(string plainText, string key)
    {
        if (string.IsNullOrWhiteSpace(key))
        {
            throw new ArgumentException("Key cannot be null or empty.", nameof(key));
        }

        byte[] keyBytes = Encoding.UTF8.GetBytes(key);

        if (keyBytes.Length != 16 && keyBytes.Length != 24 && keyBytes.Length != 32)
        {
            throw new ArgumentException("Invalid AES key size. Key must be 16, 24, or 32 bytes.", nameof(key));
        }

        byte[] iv = new byte[16];

        using Aes aes = Aes.Create();
        aes.Key = keyBytes;
        aes.IV = iv;

        using MemoryStream ms = new();
        using (CryptoStream cs = new(ms, aes.CreateEncryptor(), CryptoStreamMode.Write))
        {
            byte[] plainBytes = Encoding.UTF8.GetBytes(plainText);
            cs.Write(plainBytes, 0, plainBytes.Length);
            cs.FlushFinalBlock();
        }

        return Convert.ToBase64String(ms.ToArray());
    }

    public static string DecryptWithKey(string encryptedText, string key)
    {
        if (string.IsNullOrWhiteSpace(encryptedText))
        {
            return string.Empty;
        }

        if (string.IsNullOrWhiteSpace(key))
        {
            throw new ArgumentException("Key cannot be null or empty.", nameof(key));
        }

        byte[] keyBytes = Encoding.UTF8.GetBytes(key);
        byte[] iv = new byte[16];
        byte[] encryptedBytes = Convert.FromBase64String(encryptedText);

        using Aes aes = Aes.Create();
        aes.Key = keyBytes;
        aes.IV = iv;

        using MemoryStream ms = new();
        using (CryptoStream cs = new(ms, aes.CreateDecryptor(), CryptoStreamMode.Write))
        {
            cs.Write(encryptedBytes, 0, encryptedBytes.Length);
            cs.FlushFinalBlock();
        }

        return Encoding.UTF8.GetString(ms.ToArray());
    }
}

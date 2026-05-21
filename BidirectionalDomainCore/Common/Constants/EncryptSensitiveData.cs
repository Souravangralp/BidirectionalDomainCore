using Bidirectional.Application.Common;
using Newtonsoft.Json.Linq;

namespace Bidirectional.DomainCore.Common.Constants
{
    /// <summary>
    /// Provides utility methods for encrypting sensitive data within JSON objects and defines field names to be encrypted or ignored.
    /// </summary>
    public static class EncryptSensitiveData
    {
        /// <summary>
        /// Prefix indicating that a value has been encrypted.
        /// </summary>
        public const string EncryptedPrefix = "ENC:";

        /// <summary>
        /// Encrypts the values of sensitive fields within a JSON payload using the provided encryption key.
        /// </summary>
        /// <param name="json">The JSON string containing the data to be processed.</param>
        /// <param name="encryptKey">The encryption key used for encrypting sensitive fields.</param>
        /// <returns>
        /// A JSON string where sensitive field values are encrypted, or the original string if the input is null or whitespace.
        /// </returns>
        public static string EncryptSensitiveJson(string json, string encryptKey)
        {
            if (string.IsNullOrWhiteSpace(json)) return json;

            JToken token = Newtonsoft.Json.Linq.JToken.Parse(json);

            EncryptToken(token, encryptKey);

            return token.ToString(Newtonsoft.Json.Formatting.None);
        }

        /// <summary>
        /// Recursively encrypts sensitive string fields in the given JSON token using the specified key.
        /// </summary>
        /// <param name="token">The JSON token to process and encrypt.</param>
        /// <param name="key">The encryption key to use for encryption.</param>
        private static void EncryptToken(Newtonsoft.Json.Linq.JToken token, string key)
        {
            if (token.Type == Newtonsoft.Json.Linq.JTokenType.Object)
            {
                foreach (JProperty? prop in token.Children<Newtonsoft.Json.Linq.JProperty>().ToList())
                {
                    if (IgnoreFields.Contains(prop.Name))
                    {
                        prop.Remove();
                        continue;
                    }
                    // Only encrypt string fields in the sensitive list
                    if (SensitiveFields.Contains(prop.Name) && prop.Value.Type == Newtonsoft.Json.Linq.JTokenType.String)
                    {
                        string value = prop.Value.ToString();

                        // Skip if already encrypted
                        if (!value.StartsWith(EncryptedPrefix) && !string.IsNullOrWhiteSpace(value))
                        {
                            string encrypted = EncryptDecryptData.EncryptWithKey(value, key);
                            prop.Value = EncryptedPrefix + encrypted;
                        }
                    }
                    else
                    {
                        // Recurse into nested objects or arrays
                        EncryptToken(prop.Value, key);
                    }
                }
            }
            else if (token.Type == Newtonsoft.Json.Linq.JTokenType.Array)
            {
                foreach (JToken item in token.Children())
                {
                    EncryptToken(item, key);
                }
            }
        }

        /// <summary>
        /// A collection of field names that should have their values encrypted when found in a JSON payload.
        /// </summary>
        public static readonly HashSet<string> SensitiveFields =
            new(StringComparer.OrdinalIgnoreCase)
            {
              // 1. Financial account identifiers
              "accountNumber",
              "accountNumber",
  
              // 2. Email addresses
              "Email",
              "userEmail",
              "email",
  
              // 3. Phone numbers
              "PhoneNumber",
              "phoneNumber",
              "whatsAppNumber",
  
              // 4. Government-issued IDs
              "migrantVisaNumber",
              "driverLicense",
              "passport",
  
              // 5. Financial amounts in loan context
              "LoanAmount",
              "investmentAmount",
              "balanceOutstanding",
              "creditLimit",
  
              // 6. IP addresses (location tracking)
              "ipAddress",
  
              // 7. Credit scores/ratings
              "equifaxCreditScore",
              "equifaxCreditIndex",
              "illionCreditIndex",
  
              // 8. Full address information
              "fullAddress",
  
              // 9. Income information
              "income",
              "annualIncomeAmount",
  
              // 10. Bank/credit card details
              "creditCardCount",  // indicates financial exposure
              "creditLimit",
              "amountCurrentlyOwing"
            };

        /// <summary>
        /// A collection of field names that should be ignored and excluded from encryption during processing.
        /// </summary>
        public static readonly HashSet<string> IgnoreFields =
           new(StringComparer.OrdinalIgnoreCase)
           {
           "Authorization"
           };
    }
}

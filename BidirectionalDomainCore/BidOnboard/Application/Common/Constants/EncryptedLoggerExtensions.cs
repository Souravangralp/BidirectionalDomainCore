using Bidirectional.Application.Constants;
using Bidirectional.DomainCore.Common.Constants;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Bidirectional.Application.Common.Constants;

/// <summary>
/// Provides extension methods for ILogger to securely log information and errors with sensitive data encryption.
/// </summary>
public static class EncryptedLoggerExtensions
{
    /// <summary>
    /// Determines whether the specified input string is valid JSON.
    /// </summary>
    /// <param name="input">The string to check for JSON validity.</param>
    /// <returns>True if the input is valid JSON; otherwise, false.</returns>
    private static bool IsJson(string input)
    {
        if (string.IsNullOrWhiteSpace(input))
            return false;

        input = input.Trim();

        if (!(input.StartsWith("{") && input.EndsWith("}")) &&
            !(input.StartsWith("[") && input.EndsWith("]")))
            return false;

        try
        {
            JToken.Parse(input);
            return true;
        }
        catch
        {
            return false;
        }
    }

    /// <summary>
    /// Logs an information message with an optional payload, encrypting sensitive data before logging.
    /// </summary>
    /// <param name="logger">The logger instance used to write the log.</param>
    /// <param name="message">The information message to log.</param>
    /// <param name="payload">The object containing sensitive data to encrypt and include in the log. Can be null.</param>
    public static void LogInformationEncrypted(
        this Microsoft.Extensions.Logging.ILogger logger,
        string message,
        object? payload)
    {
        if (payload == null)
        {
            logger.LogInformation(message);
            return;
        }
        try
        {
            string json = payload is string s && IsJson(s)
                ? s
                : JsonConvert.SerializeObject(payload);

            string encryptedJson =
                EncryptSensitiveData.EncryptSensitiveJson(
                    json,
                    EncryptionKeyAccessor.Provider.Key);

            const int maxPayloadLength = 8_000;

            IReadOnlyDictionary<string, object?> scopeData = EncryptedLoggerExtensionsHelpers.ChunkPayload(encryptedJson, maxPayloadLength);

            using (logger.BeginScope(scopeData))
            {
                logger.LogInformation("{Message}", message);
            }
        }
        catch
        {
            logger.LogInformation("{Message}", message);
        }
    }

    /// <summary>
    /// Logs an error message, encrypting sensitive exception details before logging.
    /// </summary>
    /// <param name="logger">The logger instance used to write the log.</param>
    /// <param name="exception">The exception to encrypt and log.</param>
    /// <param name="messageTemplate">The message template for the log entry.</param>
    /// <param name="args">The arguments for the message template.</param>
    public static void LogErrorEncrypted(
        this Microsoft.Extensions.Logging.ILogger logger,
        Exception exception,
        string messageTemplate,
        params object[] args)
    {
        Exception safeException = EncryptException(exception);

        logger.LogError(safeException, messageTemplate, args);
    }

    /// <summary>
    /// Encrypts the message of the provided exception and returns a new exception with the encrypted message.
    /// </summary>
    /// <param name="ex">The exception whose message will be encrypted.</param>
    /// <returns>A new Exception instance with the encrypted message.</returns>
    private static Exception EncryptException(Exception ex)
    {
        string encryptedMessage =
            EncryptSensitiveData.EncryptSensitiveJson(
                JsonConvert.SerializeObject(new { ex.Message }),
                EncryptionKeyAccessor.Provider.Key);

        return new Exception(encryptedMessage, ex.InnerException);
    }
}

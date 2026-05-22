namespace Bidirectional.DomainCore.BidOnboard.Infrastructure.Bid.Common;

/// <summary>
/// Provides helper methods for encrypted logger extensions.
/// </summary>
public static class EncryptedLoggerExtensionsHelpers
{
    /// <summary>
    /// Splits the provided payload string into smaller chunks of the specified size,
    /// returning a dictionary where each chunk is associated with a unique key.
    /// The total number of chunks is also included in the dictionary.
    /// </summary>
    /// <param name="payload">The input string payload to be chunked.</param>
    /// <param name="chunkSize">The maximum size of each chunk.</param>
    /// <returns>
    /// A read-only dictionary containing the chunked payload segments with keys in the format "EncryptedPayload_{index}",
    /// and the total number of chunks under the key "EncryptedPayload_TotalChunks".
    /// </returns>
    public static IReadOnlyDictionary<string, object?> ChunkPayload(
        string payload,
        int chunkSize)
    {
        Dictionary<string, object?> chunks = new Dictionary<string, object?>();

        int totalChunks = (int)Math.Ceiling(payload.Length / (double)chunkSize);

        for (int i = 0; i < totalChunks; i++)
        {
            string chunk = payload.Substring(
                i * chunkSize,
                Math.Min(chunkSize, payload.Length - i * chunkSize));

            chunks[$"EncryptedPayload_{i + 1}"] = chunk;
        }

        chunks["EncryptedPayload_TotalChunks"] = totalChunks;

        return chunks;
    }
}


using Bidirectional.DomainCore.BidOnboard.Persistence.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bidirectional.DomainCore.BidOnboard.Extension
{
    /// <summary>
    /// Provides extension methods for working with grouped general lookup DTOs.
    /// </summary>
    public static class GeneralLookUpExtension
    {
        /// <summary>
        /// Retrieves the lookup item's <c>Value</c> for a given lookup group <paramref name="type"/> and item <paramref name="id"/>.
        /// </summary>
        /// <param name="lookups">The list of grouped lookup DTOs to search. May be <c>null</c>.</param>
        /// <param name="type">The lookup group type to match. Comparison is case-insensitive (ordinal).</param>
        /// <param name="id">The identifier of the lookup item to find. May be <c>null</c>.</param>
        /// <returns>
        /// The matching item's <c>Value</c> when a group with the specified <paramref name="type"/> and an item with the specified
        /// <paramref name="id"/> are found; otherwise <c>null</c>. Also returns <c>null</c> if <paramref name="lookups"/> is <c>null</c>,
        /// <paramref name="type"/> is <c>null</c> or empty, or <paramref name="id"/> is <c>null</c>.
        /// </returns>
        /// <remarks>
        /// - Uses <see cref="StringComparison.OrdinalIgnoreCase"/> for matching the group <paramref name="type"/>.
        /// - If multiple groups have the same <paramref name="type"/>, the first matching group's <c>Items</c> collection is searched.
        /// - The method performs safe null checks and will not throw for missing inputs; it simply returns <c>null</c> when no match exists.
        /// </remarks>
        public static string? GetValueByTypeAndId(
            this List<GeneralLookUpGroupedDto> lookups,
            string type,
            int? id)
        {
            if (lookups == null || string.IsNullOrEmpty(type) || id == null)
            {
                return null;
            }

            return lookups
                .FirstOrDefault(x => x.Type.Equals(type, StringComparison.OrdinalIgnoreCase))
                ?.Items
                .FirstOrDefault(i => i.ID == id.Value)
                ?.Value;
        }
    }

}

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Text.RegularExpressions;

namespace Bidirectional.DomainCore.BidOnboard.Infrastructure.Bid.Common
{
    /// <summary>
    /// Provides utility methods for creating user-friendly error messages for text policy violations.
    /// </summary>
    public static class TextPolicyErrorFormatter
    {
        /// <summary>
        /// Builds a user-friendly error message based on the specified field path, field class, violation type, and text policy.
        /// </summary>
        /// <param name="fieldPath">The path of the field being validated.</param>
        /// <param name="fieldClass">The classification of the field for policy purposes.</param>
        /// <param name="violation">The type of text policy violation encountered.</param>
        /// <param name="_">The text policy applied (unused).</param>
        /// <returns>A descriptive error message appropriate to the validation context.</returns>
        public static string Build(
            string fieldPath,
            TextFieldClass fieldClass,
            TextPolicyViolation violation,
            TextPolicy _)
        {
            string fieldName = fieldPath.Split('.').Last();
            string field = ToHumanReadable(fieldPath);

            return violation switch
            {
                TextPolicyViolation.EmptyOrWhitespace =>
                    $"Please enter a value for {field}.",

                TextPolicyViolation.ExceedsMaxLength =>
                    $"Please keep {field} within the allowed character limit.",

                TextPolicyViolation.UnicodeNotAllowed =>
                    $"Please use only standard English letters in {field}.",

                TextPolicyViolation.InvalidCharacters =>
                    GetInvalidCharacterMessage(field, fieldClass),

                TextPolicyViolation.DangerousContent =>
                     $"{field} contains content that is not allowed for security reasons.",

                TextPolicyViolation.SqlPatternViolation =>
                    $"{field} contains restricted or prohibited content.",

                TextPolicyViolation.InvalidJson =>
                    $"Please enter data in a valid JSON format for {field}.",

                TextPolicyViolation.InvalidXml =>
                    $"Please enter data in a valid XML format for {field}.",

                TextPolicyViolation.InvalidHtml =>
                    $"HTML content is not allowed in {field}.",

                _ =>
                    $"Please enter a valid value for {field}."
            };
        }

        /// <summary>
        /// Generates an error message indicating the specific invalid character issue for the given field and field class.
        /// </summary>
        /// <param name="field">The display name of the field.</param>
        /// <param name="fieldClass">The classification of the field for policy purposes.</param>
        /// <returns>An error message tailored to the invalid character scenario.</returns>
        private static string GetInvalidCharacterMessage(string field, TextFieldClass fieldClass)
        {
            return fieldClass switch
            {
                TextFieldClass.ControlledIdentifier =>
                    $"Please use only letters, numbers, or hyphens in {field}.",

                TextFieldClass.Url =>
                    $"Please enter a valid website address for {field}.",

                TextFieldClass.FreeTextNarrative =>
                    $"Please enter plain text only for {field}. Special characters are not allowed.",

                TextFieldClass.Comment =>
                    $"Please remove any invalid characters from {field}.",

                TextFieldClass.EncryptedText =>
                    $"{field} is not in the correct secure format.",

                TextFieldClass.ImportedText =>
                    $"Some characters used in {field} are not supported.",

                _ =>
                    $"Please remove any invalid characters from {field}."
            };
        }

        /// <summary>
        /// Converts a technical field path to a human-readable display name.
        /// </summary>
        /// <param name="fieldPath">The technical path of the field.</param>
        /// <returns>A human-readable string representing the field name.</returns>
        private static string ToHumanReadable(string fieldPath)
        {
            string fieldName = fieldPath.Split('.').Last();

            fieldName = fieldName.Replace("_", " ");

            fieldName = Regex.Replace(fieldName, "(?<=.)(OR|AND)(?=[A-Z])", " $1 ");

            fieldName = Regex.Replace(fieldName, "([a-z0-9])([A-Z])", "$1 $2");

            fieldName = Regex.Replace(fieldName, @"\s+", " ").Trim();

            return string.Join(" ",
                fieldName.Split(' ')
                    .Select(w => w is "OR" or "AND"
                        ? w.ToLower()
                        : CultureInfo.CurrentCulture.TextInfo.ToTitleCase(w.ToLower())));
        }
    }
}

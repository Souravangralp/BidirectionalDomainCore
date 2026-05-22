using System.Reflection;

namespace Bidirectional.DomainCore.BidOnboard.Persistence.Abstractions;

/// <summary>
/// Provides functionality to validate text input against defined text policies for specific properties.
/// </summary>
public interface ITextPolicyService
{
    /// <summary>
    /// Validates a string value against the text policy assigned to the specified property and path.
    /// </summary>
    /// <param name="property">The reflection metadata of the property to validate.</param>
    /// <param name="path">The path to the property in the object hierarchy.</param>
    /// <param name="value">The text value to validate.</param>
    /// <returns>
    /// A tuple containing:
    /// - <c>isValid</c>: Indicates whether the value complies with the policy.
    /// - <c>testClass</c>: The classification of the text field.
    /// - <c>policy</c>: The text policy applied.
    /// - <c>violation</c>: Details of the policy violation, if any.
    /// </returns>
    (bool isValid, TextFieldClass testClass, TextPolicy policy, TextPolicyViolation? violation) IsValid(PropertyInfo? property, string path, string value);
}

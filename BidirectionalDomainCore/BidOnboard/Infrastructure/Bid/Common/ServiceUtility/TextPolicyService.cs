using Bidirectional.Application.Common.Interfaces;
using System.Reflection;

namespace Bidirectional.DomainCore.BidOnboard.Infrastructure.Bid.Common.ServiceUtility;

/// <summary>
/// Provides services for resolving and validating text policies and text classes based on property metadata and path information.
/// </summary>
public class TextPolicyService : ITextPolicyService
{
    /// <inheritdoc />
    public TextPolicy Resolve(PropertyInfo? property, string path)
    {
        if (property != null)
        {
            return ModelBuilderStringConvention.ResolveTextPolicy(property, property.Name);
        }

        TextFieldClass inferred = ModelBuilderStringConvention.InferTextClassByName(path);

        if (!ModelBuilderStringConvention.Policies.TryGetValue(inferred, out TextPolicy? inferredPolicy))
        {
            throw new InvalidOperationException(
                $"No TextPolicy defined for inferred {inferred} on {path}");
        }

        return inferredPolicy;
    }

    /// <inheritdoc />
    public TextFieldClass ResolveTextClass(PropertyInfo? property, string path)
    {
        return property?.GetCustomAttribute<TextClassAttribute>()?.Class
            ?? ModelBuilderStringConvention.InferTextClassByName(path);
    }

    /// <inheritdoc />
    public (bool, TextFieldClass, TextPolicy, TextPolicyViolation?) IsValid(PropertyInfo? property, string path, string value)
    {
        TextPolicy policy = Resolve(property, path);
        TextFieldClass textClass = ResolveTextClass(property, path);
        bool isValid = policy.IsSatisfiedBy(
            property,
            value,
            textClass,
            out TextPolicyViolation? violations);

        return (isValid, textClass, policy, violations);
    }
}

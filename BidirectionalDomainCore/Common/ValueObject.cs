namespace Bidirectional.DomainCore.Common;

/// <summary>
/// Represents an object whose equality is based on the values of its components rather than reference.
/// </summary>
public abstract class ValueObject
{
    #region Methods

    /// <summary>
    /// Determines whether two <see cref="ValueObject"/> instances are equal.
    /// </summary>
    /// <param name="left">The left value object to compare.</param>
    /// <param name="right">The right value object to compare.</param>
    /// <returns><c>true</c> if the objects are equal; otherwise, <c>false</c>.</returns>
    protected static bool EqualOperator(ValueObject left, ValueObject right)
    {
        if (left is null ^ right is null)
        {
            return false;
        }

        return left?.Equals(right!) != false;
    }

    /// <summary>
    /// Determines whether two <see cref="ValueObject"/> instances are not equal.
    /// </summary>
    /// <param name="left">The left value object to compare.</param>
    /// <param name="right">The right value object to compare.</param>
    /// <returns><c>true</c> if the objects are not equal; otherwise, <c>false</c>.</returns>
    protected static bool NotEqualOperator(ValueObject left, ValueObject right)
    {
        return !(EqualOperator(left, right));
    }

    /// <summary>
    /// Gets the atomic values that are used for equality comparisons.
    /// </summary>
    /// <returns>An enumerable of the objects that define the equality of the value object.</returns>
    protected abstract IEnumerable<object> GetEqualityComponents();

    /// <summary>
    /// Determines whether the specified object is equal to the current value object.
    /// </summary>
    /// <param name="obj">The object to compare with the current value object.</param>
    /// <returns><c>true</c> if the specified object is equal to the current value object; otherwise, <c>false</c>.</returns>
    public override bool Equals(object? obj)
    {
        if (obj is null || obj.GetType() != GetType())
        {
            return false;
        }

        ValueObject other = (ValueObject)obj;
        return GetEqualityComponents().SequenceEqual(other.GetEqualityComponents());
    }

    /// <summary>
    /// Returns a hash code for the value object based on its equality components.
    /// </summary>
    /// <returns>A hash code for the current value object.</returns>
    public override int GetHashCode()
    {
        return GetEqualityComponents()
            .Select(x => x is not null ? x.GetHashCode() : 0)
            .Aggregate((x, y) => x ^ y);
    }
    #endregion
}

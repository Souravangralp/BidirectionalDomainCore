using Bidirectional.DomainCore.BidOnboard.Exceptions;

namespace Bidirectional.DomainCore.BidOnboard.ValueObjects;

/// <summary>
/// Represents a color value object with predefined and custom colors, supporting value-based equality and conversion.
/// </summary>
public class Colour : ValueObject
{
    static Colour()
    {
    }

    private Colour()
    {
    }

    private Colour(string code)
    {
        Code = code;
    }

    /// <summary>
    /// Creates a Colour instance from the specified color code, if it is supported.
    /// </summary>
    /// <param name="code">The hexadecimal code representing the color.</param>
    /// <returns>A Colour instance corresponding to the specified code.</returns>
    /// <exception cref="UnsupportedColourException">Thrown when the specified color code is not supported.</exception>
    public static Colour From(string code)
    {
        Colour colour = new Colour { Code = code };

        if (!SupportedColours.Contains(colour))
        {
            throw new UnsupportedColourException(code);
        }

        return colour;
    }

    /// <summary>
    /// Gets a Colour representing white (#FFFFFF).
    /// </summary>
    public static Colour White => new("#FFFFFF");

    /// <summary>
    /// Gets a Colour representing red (#FF5733).
    /// </summary>
    public static Colour Red => new("#FF5733");

    /// <summary>
    /// Gets a Colour representing orange (#FFC300).
    /// </summary>
    public static Colour Orange => new("#FFC300");

    /// <summary>
    /// Gets a Colour representing yellow (#FFFF66).
    /// </summary>
    public static Colour Yellow => new("#FFFF66");

    /// <summary>
    /// Gets a Colour representing green (#CCFF99).
    /// </summary>
    public static Colour Green => new("#CCFF99");

    /// <summary>
    /// Gets a Colour representing blue (#6666FF).
    /// </summary>
    public static Colour Blue => new("#6666FF");

    /// <summary>
    /// Gets a Colour representing purple (#9966CC).
    /// </summary>
    public static Colour Purple => new("#9966CC");

    /// <summary>
    /// Gets a Colour representing grey (#999999).
    /// </summary>
    public static Colour Grey => new("#999999");

    /// <summary>
    /// Gets the hexadecimal color code of this Colour.
    /// </summary>
    public string Code { get; private set; } = "#000000";

    /// <summary>
    /// Implicitly converts a Colour to its string representation (color code).
    /// </summary>
    /// <param name="colour">The Colour instance to convert.</param>
    /// <returns>The color code as a string.</returns>
    public static implicit operator string(Colour colour)
    {
        return colour.ToString();
    }

    /// <summary>
    /// Explicitly converts a string color code to a Colour instance.
    /// </summary>
    /// <param name="code">The color code to convert.</param>
    /// <returns>A Colour instance corresponding to the given code.</returns>
    public static explicit operator Colour(string code)
    {
        return From(code);
    }

    /// <summary>
    /// Returns the string representation of the color code.
    /// </summary>
    /// <returns>The color code as a string.</returns>
    public override string ToString()
    {
        return Code;
    }

    /// <summary>
    /// Gets a collection of all supported Colour instances.
    /// </summary>
    protected static IEnumerable<Colour> SupportedColours
    {
        get
        {
            yield return White;
            yield return Red;
            yield return Orange;
            yield return Yellow;
            yield return Green;
            yield return Blue;
            yield return Purple;
            yield return Grey;
        }
    }

    /// <summary>
    /// Provides the components that determine value equality for Colour.
    /// </summary>
    /// <returns>A sequence of objects representing the equality components.</returns>
    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Code;
    }
}

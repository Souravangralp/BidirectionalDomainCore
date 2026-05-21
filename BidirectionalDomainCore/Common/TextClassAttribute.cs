namespace Bidirectional.DomainCore.Common;

#region Field classification

/// <summary>
/// Specifies a text field classification attribute for a property, enabling the classification of text fields with a <see cref="TextFieldClass"/>.
/// </summary>
[AttributeUsage(AttributeTargets.Property)]
public sealed class TextClassAttribute : Attribute
{
    /// <summary>
    /// Gets the text field classification for the property.
    /// </summary>
    public TextFieldClass Class { get; }

    /// <summary>
    /// Initializes a new instance of the <see cref="TextClassAttribute"/> class with the specified text field classification.
    /// </summary>
    /// <param name="class">The <see cref="TextFieldClass"/> value classifying the text property.</param>
    public TextClassAttribute(TextFieldClass @class) => Class = @class;
}

#endregion

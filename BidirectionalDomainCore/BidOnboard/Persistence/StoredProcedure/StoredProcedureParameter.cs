namespace Bidirectional.Application.Common.StoredProcedure;

/// <summary>
/// Represents a parameter for a stored procedure, including its name and value.
/// </summary>
public class StoredProcedureParameter
{
    public string? ParameterName { get; set; }

    public string? ParameterValue { get; set; }
}

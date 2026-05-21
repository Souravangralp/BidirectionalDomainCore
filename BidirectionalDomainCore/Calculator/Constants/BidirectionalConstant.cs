namespace Bidirectional.DomainCore.Calculator.Constants;

/// <summary>
/// Base URLs and authenticate endpoint templates for the Bidirectional API (live and development).
/// Used for outbound calls to the loan application API (e.g. authentication with ClientID and ClientSecret).
/// </summary>
public class BidirectionalConstant
{
    /// <summary>Gets or sets the live API base URL (production) (get set).</summary>
    public static string LiveBaseUrl { get; set; } = "https://bidirectionalloanapp.com.au/api";

    /// <summary>Gets or sets the development API base URL (localhost) (get set).</summary>
    public static string DevBaseUrl { get; set; } = "https://localhost:5002/api";
    //public static string DevBaseUrl { get; set; } = "https://bidirectionaldev.azurewebsites.net/api";

    /// <summary>Gets or sets the live authenticate endpoint template; {0} = ClientID, {1} = ClientSecret (get set).</summary>
    public static string LiveAuthenticate { get; set; } = LiveBaseUrl + "/authenticate?ClientID={0}&ClientSecret={1}";

    /// <summary>Gets or sets the development authenticate endpoint template; {0} = ClientID, {1} = ClientSecret (get set).</summary>
    public static string DevAuthenticate { get; set; } = DevBaseUrl + "/authenticate?ClientID={0}&ClientSecret={1}";
}

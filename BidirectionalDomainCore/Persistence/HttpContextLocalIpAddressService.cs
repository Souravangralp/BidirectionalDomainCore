using Bidirectional.DomainCore.BidOnboard.Persistence.Abstractions;
using Microsoft.AspNetCore.Http;
using System.Net;

namespace Bidirectional.DomainCore.Persistence
{
    public class HttpContextLocalIpAddressService : IGetLocalIPAddress
    {
        private readonly IHttpContextAccessor _httpContextAccessor;

        public HttpContextLocalIpAddressService(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        public string? GetLocalIPAddress()
        {
            string? localIP = string.Empty;

            try
            {
                // Access the HttpContext from the IHttpContextAccessor
                HttpContext? httpContext = _httpContextAccessor.HttpContext;

                // Retrieve the client's IP address from the Connection property
                IPAddress? remoteIpAddress = httpContext?.Connection?.RemoteIpAddress;

                // Check if the remote IP address is null
                if (remoteIpAddress is null)
                {

                    return localIP; // Return empty string if the remote IP address is null
                }

                // Convert the IP address to IPv4 format
                localIP = remoteIpAddress.MapToIPv4()?.ToString();

                // Check if the converted IP address is null or empty
                if (string.IsNullOrWhiteSpace(localIP))
                {
                    throw new Exception("Unable to convert the client's IP address to IPv4 format");
                }

                return localIP;
            }
            catch (Exception)
            {
                return localIP ?? string.Empty; // Return empty string in case of any exceptions
            }
        }
    }
}

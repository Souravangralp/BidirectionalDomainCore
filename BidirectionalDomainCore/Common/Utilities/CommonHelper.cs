using Microsoft.AspNetCore.Http;
using System.Net;

namespace Bidirectional.DomainCore.Common.Utilities
{
    /// <summary>
    /// Provides common utility methods for handling time zone and string formatting operations.
    /// </summary>
    public static class CommonHelper
    {
        /// <summary>
        /// Gets the current date and time in the Australian Eastern Standard Time zone.
        /// </summary>
        /// <returns>
        /// The current <see cref="DateTime"/> in Australian Eastern Standard Time (AEST).
        /// </returns>
        public static DateTime GetAustralianTime()
        {
            TimeZoneInfo timeZoneAustralia = TimeZoneInfo.FindSystemTimeZoneById("AUS Eastern Standard Time");
            return TimeZoneInfo.ConvertTimeFromUtc(DateTime.UtcNow, timeZoneAustralia);
        }

        /// <summary>
        /// Formats the provided details into a structured string for logging or tracing purposes.
        /// </summary>
        /// <param name="ipAddress">The IP address from where the action originated.</param>
        /// <param name="userId">The user identifier associated with the action (nullable).</param>
        /// <param name="actionName">The name of the performed action.</param>
        /// <param name="className">The name of the class where the action occurred.</param>
        /// <param name="methodName">The name of the method executing the action.</param>
        /// <param name="exception">Exception message if an error occurred (nullable).</param>
        /// <param name="stackTrace">Stack trace details if an exception occurred (nullable).</param>
        /// <param name="message">A custom message or detail about the action.</param>
        /// <returns>
        /// A formatted string containing all provided details for consistent log entries.
        /// </returns>
        public static string FormatString(string ipAddress, string? userId, string actionName, string className, string methodName, string? exception, string? stackTrace, string message)
        {
            return "Ip:- " + ipAddress + ", " +
                   (userId != null ? " User Id:- " + userId + ", " : "") +
                   "Action Name:- " + actionName + ", " +
                   "Class Name:- " + className + ", " +
                   "Method Name:- " + methodName + ", " +
                   (exception != null ? "Exception:- " + exception + ", " : "") +
                   (stackTrace != null ? "Stack Trace:- " + stackTrace + ", " : "") +
                   "Message:- " + message;
        }

        /// <summary>
        /// Determines whether the request originates from a local source.
        /// </summary>
        /// <param name="context">The HTTP context of the request.</param>
        /// <returns>
        /// <c>true</c> if the request is from a local source; otherwise, <c>false</c>.
        /// </returns>
        public static bool IsLocalRequest(HttpContext context)
        {
            ConnectionInfo connection = context.Connection;
            if (connection.RemoteIpAddress is null)
            {
                // Connection is from a local source
                return true;
            }

            if (connection.RemoteIpAddress.Equals(connection.LocalIpAddress))
            {
                // Remote IP equals local IP
                return true;
            }

            if (IPAddress.IsLoopback(connection.RemoteIpAddress))
            {
                // Remote IP is a loopback address
                return true;
            }

            return false;
        }
    }

}

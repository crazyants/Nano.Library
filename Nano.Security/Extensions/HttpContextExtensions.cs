using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using Microsoft.AspNetCore.Http;

namespace Nano.Security.Extensions
{
    /// <summary>
    /// Http Context Extensions.
    /// </summary>
    public static class HttpContextExtensions
    {
        /// <summary>
        /// Get Jwt User Id.
        /// </summary>
        /// <param name="httpContext">The <see cref="HttpContext"/>.</param>
        /// <returns>The user id.</returns>
        public static Guid? GetJwtUserId(this HttpContext httpContext)
        {
            if (httpContext == null)
                throw new ArgumentNullException(nameof(httpContext));

            var value = httpContext.User
                .FindFirstValue(JwtRegisteredClaimNames.Sub);

            if (value == null)
                return null;

            var success = Guid.TryParse(value, out var result);

            return success 
                ? result 
                : (Guid?)null;
        }

        /// <summary>
        /// Get Jwt User Name.
        /// </summary>
        /// <param name="httpContext">The <see cref="HttpContext"/>.</param>
        /// <returns>The user name.</returns>
        public static string GetJwtUserName(this HttpContext httpContext)
        {
            if (httpContext == null)
                throw new ArgumentNullException(nameof(httpContext));

            var value = httpContext.User
                .FindFirstValue(ClaimTypes.Name);

            return value;
        }

        /// <summary>
        /// Get Jwt User Email.
        /// </summary>
        /// <param name="httpContext">The <see cref="HttpContext"/>.</param>
        /// <returns>The email.</returns>
        public static string GetJwtUserEmail(this HttpContext httpContext)
        {
            if (httpContext == null)
                throw new ArgumentNullException(nameof(httpContext));

            var value = httpContext.User
                .FindFirstValue(JwtRegisteredClaimNames.Email);

            return value;
        }
    }
}
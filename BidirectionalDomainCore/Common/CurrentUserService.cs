using Bidirectional.Application.Common;
using Bidirectional.DomainCore.BidOnboard.Persistence.Abstractions;
using Bidirectional.DomainCore.Common.Constants;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Text;

namespace Bidirectional.DomainCore.Common
{
    public class CurrentUserService : ICurrentUserService
    {
        #region Fields  

        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IConfiguration _config;

        #endregion

        #region Ctor

        public CurrentUserService(
            IHttpContextAccessor httpContextAccessor,
            IConfiguration configuration)
        {
            _httpContextAccessor = httpContextAccessor;
            _config = configuration;
        }

        #endregion

        public string? UserID => GetClaimValue(CustomClaimTypes.UserID);

        public int? RawUserID => GetDecryptedIntClaim(CustomClaimTypes.RawUserID);

        public string? AzureAccountID => GetClaimValue(ClaimTypes.Sid);

        public string? UserName => GetClaimValue(ClaimTypes.Name);

        public string? OrganizationID => GetClaimValue(CustomClaimTypes.CompanyID);

        public int? RawOrganizationID => GetDecryptedIntClaim(CustomClaimTypes.RawCompanyID);

        public string? BusinessUnitID => GetClaimValue(CustomClaimTypes.BranchID);

        public int? RawBusinessUnitID => GetDecryptedIntClaim(CustomClaimTypes.RawBranchID);

        public string? AggregatorID => GetClaimValue(CustomClaimTypes.AggregatorID);

        public int? RawAggregatorID => GetDecryptedIntClaim(CustomClaimTypes.RawAggregatorID);

        public string? GroupID => GetClaimValue(CustomClaimTypes.GroupID);

        private string? GetClaimValue(string claimType) =>
            _httpContextAccessor.HttpContext?.User?.FindFirst(claimType)?.Value;

        private int? GetDecryptedIntClaim(string claimType)
        {
            string? encryptedValue = GetClaimValue(claimType);
            string key = _config["EncryptTokenValue:Key"] ?? string.Empty;

            if (string.IsNullOrEmpty(encryptedValue) || string.IsNullOrEmpty(key))
                return null;

            string decryptedValue = EncryptDecryptData.DecryptWithKey(encryptedValue, key);

            return int.TryParse(decryptedValue, out int intValue) ? intValue : null;
        }

        //string? ICurrentUserService.UserId { get; set; }
        //string? ICurrentUserService.UserName { get; set; }
        //string? ICurrentUserService.AzureAccountId { get; set; }
        //string? ICurrentUserService.CompanyID { get; set; }
        //string? ICurrentUserService.BranchID { get; set; }
        //string? ICurrentUserService.GroupID { get; set; }
        //string? ICurrentUserService.AggregatorID { get; set; }
    }

}

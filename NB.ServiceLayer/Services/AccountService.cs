using NB.Common;
using NB.DataLayer.Context;
using NB.DomainClasses;
using NB.ServiceLayer.IServices;
using NB.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NB.ServiceLayer.Services
{
   public class AccountService : IAccountService
    {
        private readonly ITokenFactoryService _tokenFactoryService;
        private readonly IUnitOfWork _uow;
        private readonly IAntiForgeryCookieService _antiforgery;
        private readonly ITokenStoreService _tokenStoreService;

        public AccountService(ITokenFactoryService tokenFactoryService,
            ITokenStoreService tokenStoreService,
            IUnitOfWork uow,
            IAntiForgeryCookieService antiforgery)
        {
            _tokenFactoryService = tokenFactoryService;
            _tokenFactoryService.CheckArgumentIsNull(nameof(tokenFactoryService));
            _uow = uow;
            _antiforgery = antiforgery;
            _antiforgery.CheckArgumentIsNull(nameof(antiforgery));
            _tokenStoreService = tokenStoreService;
            _tokenStoreService.CheckArgumentIsNull(nameof(tokenStoreService));
        }
        public async Task<JwtTokensData> CreateJwtTokens(User user)
        {
            var result= await _tokenFactoryService.CreateJwtTokensAsync(user);
            await _tokenStoreService.AddUserTokenAsync(user, result.RefreshTokenSerial, result.AccessToken, null);
            await _uow.SaveChangesAsync();
            _antiforgery.RegenerateAntiForgeryCookies(result.Claims);
            return result;

        }
    }
}

using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using NB.DataLayer.Context;
using NB.ServiceLayer.IServices;
using NB.ServiceLayer.Services;
using NB.Services;


namespace NB.Config
{
   public static class Bootstrapper
    {
        public static void WireUp(IServiceCollection services)
        {
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddScoped<IAntiForgeryCookieService, AntiForgeryCookieService>();
            services.AddScoped<IUnitOfWork, ApplicationDbContext>();
            services.AddScoped<IUsersService, UsersService>();
            services.AddScoped<IRolesService, RolesService>();
            services.AddSingleton<ISecurityService, SecurityService>();
            services.AddScoped<IDbInitializerService, DbInitializerService>();
            services.AddScoped<ITokenStoreService, TokenStoreService>();
            services.AddScoped<ITokenValidatorService, TokenValidatorService>();
            services.AddScoped<ITokenFactoryService, TokenFactoryService>();
            services.AddScoped<IAccountService, AccountService>();
        }
    }
}

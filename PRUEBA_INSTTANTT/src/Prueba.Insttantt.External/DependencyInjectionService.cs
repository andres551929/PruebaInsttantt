using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using Prueba.Insttantt.Application.External.GetTokenJwt;
using Prueba.Insttantt.External.GetTokenJwt;
using System.Text;

namespace Prueba.Insttantt.External
{
    public static class DependencyInjectionService
    {
        public static IServiceCollection AddExternal(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddSingleton<IGetTokenJwtService, GetTokenJwtService>();

            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddJwtBearer(option =>
            {
                option.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuer = true,
                    ValidateAudience = true,
                    ValidateLifetime = true,
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["JwtSettings:SecretKeyJwt"])),
                    ValidIssuer = configuration["JwtSettings:IssuerJwt"],
                    ValidAudience = configuration["JwtSettings:AudienceJwt"]

                };
            });


            return services;
        }
    }
}

using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using Prueba.Insttantt.Application.External.GetTokenJwt;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Prueba.Insttantt.External.GetTokenJwt
{
    public class GetTokenJwtService : IGetTokenJwtService
    {
        private readonly IConfiguration _configuration;

        public GetTokenJwtService(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public string Execute(string id)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            string key = _configuration["JwtSettings:SecretKeyJwt"] ?? string.Empty;
            var signinKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(key));

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim(ClaimTypes.NameIdentifier, id)
                }),
                Expires = DateTime.UtcNow.AddMinutes(60),
                SigningCredentials = new SigningCredentials(signinKey, SecurityAlgorithms.HmacSha256Signature),
                Issuer = _configuration["JwtSettings:IssuerJwt"],
                Audience = _configuration["JwtSettings:AudienceJwt"]
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            var tokenString = tokenHandler.WriteToken(token);
            return tokenString;
        }
    }
}

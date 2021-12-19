using System;
using System.IdentityModel.Tokens.Jwt;
using System.Text;
using AR.Presentetion.Domain.Models;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;

namespace AR.Presentetion.Util
{
    public class CryptoFunctions
    {

        public static string GenerateToken(IConfiguration configuration, User user)
        {
            var s = Encoding.UTF8.GetBytes(configuration["SecurityKey"]);
            SymmetricSecurityKey key = new SymmetricSecurityKey(s);

            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            int tokenExpireTimeLapse = int.Parse(configuration["TokenExpireTimeLapse"]);

            var token = new JwtSecurityToken(
                issuer: configuration["Issuer"],
                audience: configuration["Audience"],
                expires: DateTime.Now.AddMinutes(tokenExpireTimeLapse),
                signingCredentials: creds);

            return new JwtSecurityTokenHandler().WriteToken(token);
        }

    }
}

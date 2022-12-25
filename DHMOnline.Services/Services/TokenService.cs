using DHMOnline.Domain.Constants;
using DHMOnline.Domain.Dtos;
using DHMOnline.Domain.Extensions;
using DHMOnline.Domain.Items;
using DHMOnline.Services.Interfaces;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace DHMOnline.Services.Services
{
    public class TokenService : ITokenService
    {
        private IUserService<UserDto> _userService;
        public TokenService(IUserService<UserDto> userService)
        {
            _userService = userService;
        }
        public Task<string> GetTokenAsync(LoginRequestItem item)
        {
            return CreateTokenAsync(item, JwtSettingsConstants.Secret, JwtSettingsConstants.ExpireTimeMinute);
        }

        // CreateTokenAsync - Token oluşturur
        private async Task<string> CreateTokenAsync(LoginRequestItem loginItem, string secret, double tokenExpireValue)
        {
            if (loginItem == null) return String.Empty;
            if (loginItem.UserName.IsNullOrEmpty()) return String.Empty;

            //if (loginItem.UserName.ToLower() == "admin" && loginItem.Password == "1")
            var isValid = await _userService.IsValidUserLoginAsync(loginItem);
            if (isValid)
            {
                var tokenHandler = new JwtSecurityTokenHandler();
                var key = secret.ToByteArray();
                var tokenDescriptor = new SecurityTokenDescriptor
                {
                    Subject = new ClaimsIdentity(new Claim[]
                    {
                    new Claim(ClaimTypes.Name, loginItem.UserName)
                    }),
                    Expires = DateTime.UtcNow.AddMinutes(tokenExpireValue),
                    SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
                };
                var token = tokenHandler.CreateToken(tokenDescriptor);
                var tokenStr = tokenHandler.WriteToken(token);

                return await Task.FromResult(tokenStr);
            }
            else return String.Empty;
        }
    }
}

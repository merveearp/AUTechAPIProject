using AITech.DTO.TokenDtos;
using AITech.Entity.Entities;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace AITech.Business.Services.TokenServices
{
    public class TokenService : ITokenService
    {
        private readonly IConfiguration _configuration;

        public TokenService(IConfiguration configuration)
        {
            _configuration = configuration;
        }


        public LoginResponseDto CreateToken(AppUser user)
        {
            
            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
                new Claim(ClaimTypes.Email, user.Email),
                new Claim(ClaimTypes.Name, user.UserName)
            };

            
            var key = new SymmetricSecurityKey(
                Encoding.UTF8.GetBytes(_configuration["Jwt:Key"])
            );

           
            var credentials = new SigningCredentials(
                key,
                SecurityAlgorithms.HmacSha256
            );

            
            var expireDate = DateTime.UtcNow.AddMinutes(
                int.Parse(_configuration["Jwt:ExpireMinutes"])
            );

           
            var token = new JwtSecurityToken(
                issuer: _configuration["Jwt:Issuer"],
                audience: _configuration["Jwt:Audience"],
                claims: claims,
                expires: expireDate,
                signingCredentials: credentials
            );

            
            var tokenString = new JwtSecurityTokenHandler().WriteToken(token);

            
            return new LoginResponseDto
            {
                Token = tokenString,
                ExpireDate = expireDate
            };
        }
    }
}

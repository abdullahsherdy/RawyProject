﻿using core.Contracts.AuthContracts;
using core.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class AuthService : IAuthService
    {
        private readonly IConfiguration _configuration;

        public AuthService(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public async Task<string> CreateTokenAsync(BaseUser user, UserManager<BaseUser> userManager)
        {

            var authClaims = new List<Claim>()
            {
                new Claim(ClaimTypes.Name,user.UserName),
                new Claim(ClaimTypes.Email,user.Email),
                new Claim(ClaimTypes.NameIdentifier,user.Id)

            };

            var userRoles = await userManager.GetRolesAsync(user);
            foreach (var role in userRoles)
                authClaims.Add(new Claim(ClaimTypes.Role, role));

            var secretKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["JWT:SecretKey"]));

            var token = new JwtSecurityToken(
      issuer: _configuration["JWT:ValidIssuer"], 
      audience: _configuration["JWT:ValidAudience"],
      expires: DateTime.UtcNow.AddDays(double.Parse(_configuration["JWT:DurationInDays"])),
      claims: authClaims,
      signingCredentials: new SigningCredentials(secretKey, SecurityAlgorithms.HmacSha256Signature)
  );

            return new JwtSecurityTokenHandler().WriteToken(token);
        }

    }
}

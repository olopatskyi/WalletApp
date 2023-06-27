using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using WalletApp.Application.Shared;
using Microsoft.IdentityModel.Tokens;

namespace WalletApp.Application.Helpers;

public static class JwtTokenHelper
{
    internal static string GenerateJwtToken(JwtSettings settings, ClaimsIdentity claimsIdentity)
    {
        var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(settings.SecretKey));
        var signingCredentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

        var tokenDescriptor = new SecurityTokenDescriptor
        {
            Subject = claimsIdentity,
            Issuer = settings.ValidIssuer,
            Audience = settings.ValidAudience,
            Expires = DateTime.UtcNow.AddMinutes(20),
            SigningCredentials = signingCredentials
        };

        var tokenHandler = new JwtSecurityTokenHandler();
        var token = tokenHandler.CreateToken(tokenDescriptor);
        return tokenHandler.WriteToken(token);
    }

    internal static string GenerateRefreshToken(JwtSettings settings)
    {
        var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(settings.SecretKey));
        var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);
    
        var claims = new List<Claim>
        {
            new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
            new Claim(JwtRegisteredClaimNames.Sub, "refresh_token"),
        };
    
        var expiryDate = DateTime.UtcNow.AddMonths(1);
    
        var tokenDescriptor = new SecurityTokenDescriptor
        {
            Subject = new ClaimsIdentity(claims),
            Expires = expiryDate,
            SigningCredentials = credentials
        };
    
        var tokenHandler = new JwtSecurityTokenHandler();
        var token = tokenHandler.CreateToken(tokenDescriptor);
    
        return tokenHandler.WriteToken(token);
    }
}
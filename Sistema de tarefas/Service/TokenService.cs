using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using Sistema_de_tarefas.Models;

public static class TokenService
{
    public static string GenerateJwtToken(UsuarioModel usuario, IConfiguration configuration)
    {
        var claims = new[]
        {
            new Claim(JwtRegisteredClaimNames.Sub, usuario.Id.ToString()),
            new Claim(JwtRegisteredClaimNames.Email, usuario.Email),
            new Claim(ClaimTypes.Role, usuario.Cargo) // regra de cargos
        };

        var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["Jwt:706d27c8-c7ec-44ca-acd6-536f0c4445e2"]));
        var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

        var token = new JwtSecurityToken(
            issuer: configuration["Jwt:Issuer"],
            audience: configuration["Jwt:Audience"],
            claims: claims,
            expires: DateTime.Now.AddHours(1),
            signingCredentials: creds
        );

        return new JwtSecurityTokenHandler().WriteToken(token);
    }

    internal static object GenerateJwtToken(Task<UsuarioModel> usuario, IConfiguration configuration)
    {
        throw new NotImplementedException();
    }

    internal static object GenerateJwtToken(Task<LoginModel> usuario, IConfiguration configuration)
    {
        throw new NotImplementedException();
    }
}

using Microsoft.AspNetCore.Identity.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Org.BouncyCastle.Crypto.Generators;
using Sistema_de_tarefas.Models;
using Sistema_de_tarefas.Repositorios.Interface;
using System.Security;
using BCrypt.Net;




[Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly ILoginRepositorio _loginRepositorio;
        private readonly IConfiguration _configuration;

        public AuthController(ILoginRepositorio loginRepositorio, IConfiguration configuration)
        {
            _loginRepositorio = loginRepositorio;
            _configuration = configuration;
        }

        [HttpPost("login")]
        public IActionResult Login([FromBody] LoginModel loginModel)
        {
            // Buscar o usuário no repositório pelo email
            var usuario = _loginRepositorio.BuscarPorEmail(loginModel.Email);

        // Verificar se o usuário existe e se a senha está correta
        if (!(usuario != null && BCrypt.Net.BCrypt.Verify(loginModel.Senha, loginModel.Senha)))
        {
            return Unauthorized("Credenciais inválidas.");
        }

        // Gerar o token JWT
        var token = TokenService.GenerateJwtToken(usuario, _configuration);
            return Ok(new { token });
        }
    }


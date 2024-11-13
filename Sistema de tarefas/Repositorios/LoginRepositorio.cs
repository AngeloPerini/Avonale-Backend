using Microsoft.EntityFrameworkCore;
using Sistema_de_tarefas.Data;
using Sistema_de_tarefas.Models;
using Sistema_de_tarefas.Repositorios.Interface;

namespace Sistema_de_tarefas.Repositorios
{
    public class LoginRepositorio : ILoginRepositorio
    {

        private readonly SistemaTarefasDBContex _dbContext;

        public LoginRepositorio(SistemaTarefasDBContex sistemaTarefasDBContex)
        {
            _dbContext = sistemaTarefasDBContex;
        }

        public async Task<LoginModel> BuscarPorEmail(string email)
        {
            return await _dbContext.Login
                .Include(x => x.Usuario) // feito para associar o Id do Usuario e puxar as informações do mesmo
                .FirstOrDefaultAsync(x => x.Email == email);
        }
    }
}

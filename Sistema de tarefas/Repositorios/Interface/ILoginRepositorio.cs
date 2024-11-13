using Sistema_de_tarefas.Models;

namespace Sistema_de_tarefas.Repositorios.Interface
{
    public interface ILoginRepositorio
    {
        Task<LoginModel> BuscarPorEmail (string email);
        
    }
}

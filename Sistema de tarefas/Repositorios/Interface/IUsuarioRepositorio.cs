using Sistema_de_tarefas.Models;

namespace Sistema_de_tarefas.Repositorios.Interface
{
    public interface IUsuarioRepositorio
    {
        Task<List<UsuarioModel>> BuscarTodosUsuarios();
        Task<UsuarioModel> BuscarPorId (int id);
        Task<UsuarioModel> Adicionar(UsuarioModel usuario);
        Task< UsuarioModel> Atualizar(UsuarioModel usuario, int id);
        Task<bool> Apagar(int id);
    }
}

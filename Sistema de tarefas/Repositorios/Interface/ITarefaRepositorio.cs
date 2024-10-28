using Sistema_de_tarefas.Models;

namespace Sistema_de_tarefas.Repositorios.Interface
{
    public interface iTarefaRepositorio
    {
        Task<List<TarefaModel>> BuscarTarefas();
        Task<TarefaModel> BuscarPorId(int id);
        Task<TarefaModel> Adicionar(UsuarioModel tarefa);
        Task< TarefaModel> Atualizar(TarefaModel tarefa, int id);
        Task<bool> Apagar(int id);
    }
}

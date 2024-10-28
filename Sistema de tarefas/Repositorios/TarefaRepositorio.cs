using Microsoft.EntityFrameworkCore;
using Sistema_de_tarefas.Data;
using Sistema_de_tarefas.Models;

namespace Sistema_de_tarefas.Repositorios
{
    public class TarefaRepositorio
    {

        private readonly SistemaTarefasDBContex _dbContext;
        public TarefaRepositorio(SistemaTarefasDBContex sisteTarefasDBContex0)
        {
            _dbContext = _dbContext;
        }
        public async Task<TarefaModel> BuscarPorId(int id)
        {
            return await _dbContext.Tarefa.FirstOrDefaultAsync(x => x.Id == id);
        }
        public async Task<List<TarefaModel>> BuscarTarefas()
        {
            return await _dbContext.Tarefa.ToListAsync();
        }
        public async Task<TarefaModel> Adicionar(TarefaModel tarefa)
        {
            await _dbContext.Tarefa.AddAsync(tarefa);
            await _dbContext.SaveChangesAsync();

            return tarefa;
        }
        public async Task<TarefaModel> Atualizar(TarefaModel tarefa, int id)
        {
            TarefaModel tarefaPorId = await BuscarPorId(id);
            if (tarefaPorId == null)
            {
                throw new Exception($"Tarefa para o ID: {id} não foi encontrado no banco de dados");
            }

            tarefaPorId.Titulo = tarefa.Titulo;
            tarefaPorId.Descricao = tarefa.Descricao;
            tarefaPorId.Prioridade = tarefa.Prioridade;

            _dbContext.Tarefa.Update(tarefaPorId);
            await _dbContext.SaveChangesAsync();

            return tarefaPorId;
        }
        public async Task<bool> Apagar(int id)
        {
            TarefaModel tarefaPorId = await BuscarPorId(id);
            if (tarefaPorId == null)
            {
                throw new Exception($"Tarefa para o ID: {id} não foi encontrado no banco de dados");
            }
            _dbContext.Tarefa.Remove(tarefaPorId);
            await _dbContext.SaveChangesAsync();

            return true;
        }



    }
}

using Sistema_de_tarefas.Enuns;

namespace Sistema_de_tarefas.Models
{
    public class TarefaModel
    {

        public required int Id { get; set; }
        public required string? Nome { get; set; }    
        public string? Descricao { get; set; }
        public required string Prioridade { get; set; }
        public StatusTarefa Status { get; set; }
        public required string Titulo { get ; set; }

    }
}

using Sistema_de_tarefas.Enuns;
using System.ComponentModel.DataAnnotations;

namespace Sistema_de_tarefas.Models
{
    public class TarefaModel
    {
        [Key]
        public required int Id { get; set; }
        public required string? Titulo { get; set; }    
        public string? Descricao { get; set; }
        public required string Prioridade { get; set; }
        public StatusTarefa Status { get; set; }
        public int? UsuarioId { get; set; }
        
        // Ligado com o id do usuario 
        public virtual UsuarioModel? Usuario { get; set; }

    }
}

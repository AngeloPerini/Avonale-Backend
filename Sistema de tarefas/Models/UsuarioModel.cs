using System.ComponentModel.DataAnnotations;


namespace Sistema_de_tarefas.Models
{
    public class UsuarioModel
    {
        [Key]
        public required int? Id { get; set; }
        public required string? Nome { get; set; }
        public required string? Email { get; set; }
        public required string Senha { get; set; }
        public required string Cargo { get; set; }

        
    }
}

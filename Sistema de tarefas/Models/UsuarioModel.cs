using Microsoft.AspNetCore.Identity;

namespace Sistema_de_tarefas.Models
{
    public class UsuarioModel
    {
        public required int Id { get; set;}
        public required string? Nome { get; set;}
        public required string? Email { get; set; }
        public required string Senha { get; set; }

    }
}

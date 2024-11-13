using System.ComponentModel.DataAnnotations;


namespace Sistema_de_tarefas.Models
{
    public class LoginModel
    {
        [Key]
        public required string Email { get; set; }
        public required string Senha { get; set; }

        public virtual UsuarioModel? Usuario { get; set; }
    }
}

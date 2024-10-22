using System.ComponentModel;

namespace Sistema_de_tarefas.Enuns
{
    public enum StatusTarefa
    {
        [Description("A Fazer")]
        AFazer = 1,
        [Description("Em Andamento")]
        EmAndamento = 2,
        [Description("Concluido")]
        Concluida = 3,
          
    }
}

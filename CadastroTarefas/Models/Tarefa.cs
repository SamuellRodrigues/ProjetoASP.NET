using System.ComponentModel.DataAnnotations;

namespace CadastroTarefas.Models
{
    public class Tarefa
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Titulo { get; set; } = string.Empty;
        public string? Descricao { get; set; }
        public bool Concluida { get; set; }
    }
}

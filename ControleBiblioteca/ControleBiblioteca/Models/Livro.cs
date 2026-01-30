using System.ComponentModel.DataAnnotations;

namespace ControleBiblioteca.Models
{
    public class Livro
    {
        public int LivroId { get; set; }
        public string Titulo { get; set; }
        public bool Emprestado { get; set; }
        public DateTime? DataEmprestimo { get; set; }
        public DateTime? DataDevolucao { get; set; }
        public int? UsuarioId { get; set; }
        public Usuario Usuario { get; set; }
    }
}

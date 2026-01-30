namespace ControleBiblioteca.Models
{
    public class Aluno
    {
        public int AlunoId { get; set; }
        public string Nome { get; set; }

        public List<Nota> Notas { get; set; }
    }
}

namespace ControleBiblioteca.Models
{
    public class Nota
    {
        public int NotaId { get; set; }
        public double Valor { get; set; }
        public int AlunoId { get; set; }
        public Aluno Aluno { get; set; }


    }
}

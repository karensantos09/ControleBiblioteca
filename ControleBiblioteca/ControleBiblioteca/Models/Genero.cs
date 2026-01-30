namespace ControleBiblioteca.Models
{
    public class Genero
    {
        public int GeneroId { get; set; }
        public string Nome { get; set; }

        public List<Livro> Livros { get; set; }
        public int QuantidadeLivros => Livros?.Count ?? 0;
    }
}

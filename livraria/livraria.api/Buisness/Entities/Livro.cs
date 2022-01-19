using livraria.api.Models;

namespace livraria.api.Buisness.Entities
{
    public class Livro
    {
        
        public long Id { get; set; }
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public string Sinopse { get; set; }
        public TipoLivro TipoLivro { get; set; }
        public String CodigoISBN { get; set; }
        public double Valor { get; set; }
    }
}


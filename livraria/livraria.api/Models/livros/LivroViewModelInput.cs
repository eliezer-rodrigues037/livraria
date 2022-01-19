using System.ComponentModel.DataAnnotations;

namespace livraria.api.Models
{
    public class LivroViewModelInput
    {
        
        public long Id { get; set; }
        [Required(ErrorMessage = "Titulo Obrigatório")]
        public string? Titulo { get; set; }
        public string? Autor { get; set; }
        public string? Sinopse { get; set; }
        public TipoLivro TipoLivro { get; set; }
        public String? CodigoISBN { get; set; }
        public double Valor { get; set; }
    }
}

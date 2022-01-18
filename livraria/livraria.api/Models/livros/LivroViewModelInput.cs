using System.ComponentModel.DataAnnotations;

namespace livraria.api.Models
{
    public class LivroViewModelInput
    {
        [Required]
        public int LivroId { get; set; }
        [Required]
        public string? Titulo { get; set; }
        public string? Autor { get; set; }
        public string? Sinopse { get; set; }
        public TipoLivro TipoLivro { get; set; }
        public String? CodigoISBN { get; set; }
        public Decimal Valor { get; set; }
    }
}

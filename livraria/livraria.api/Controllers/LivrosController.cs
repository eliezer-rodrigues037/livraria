using livraria.api.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace livraria.api.Controllers
{
    [Route("api/v1/livros")]
    [ApiController]
    public class LivrosController : ControllerBase
    {
        [HttpPost]
        [Route("cadastrar")]
        public IActionResult CadastrarLivro(LivroViewModelInput livroViewModelInput)
        {
            return Created("", livroViewModelInput);
        }
    }
}

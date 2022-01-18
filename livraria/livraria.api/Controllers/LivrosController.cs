using livraria.api.Filters;
using livraria.api.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace livraria.api.Controllers
{
    
    [ApiController]
    [Route("api/v1/livros")]
    [Produces("application/json")]
    public class LivrosController : ControllerBase
    {
        /// <summary>
        /// Cadastra um novo livro
        /// </summary>
        ///  <remarks>
        /// Amostra de requisição:
        ///
        ///     POST /cadastrar
        ///     {
        ///        "livroId": int,
        ///        "titulo": "string",
        ///        "autor": "string",
        ///        "sinopse": "string",
        ///        "tipoLivro": 1 ou 2,
        ///        "codigoISBN": "string",
        ///        "valor": 0
        ///     }
        ///
        /// </remarks>
        /// <response code="201">Returns the newly created item</response>
        /// <response code="400">If the item is null</response>
        /// <response code="500"> Internal Server error</response>


        [HttpPost]
        [Route("cadastrar")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [CustomModelStateValidation]
        public IActionResult CadastrarLivro(LivroViewModelInput livroViewModelInput)
        {
            
            return Created("", livroViewModelInput);
        }
    }
}

#nullable disable
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using livraria.api.Buisness.Entities;
using livraria.api.Infrastructure.Data;
using livraria.api.Filters;

namespace livraria.api.Controllers
{
    [Route("api/v2/livro")]
    [ApiController]
    public class LivrosController : ControllerBase
    {
        
        private readonly LivroDbContext _context;

        public LivrosController(LivroDbContext context)
        {
            _context = context;
        }

        /// <summary>
        ///     Retorna todos os livros cadastrados
        /// </summary>
        /// <remarks>
        ///     GET: api/v2/livro/get
        /// </remarks>
        
        [HttpGet]
        [Route("get")]
        public async Task<ActionResult<IEnumerable<Livro>>> GetLivro()
        {
            return await _context.Livro.ToListAsync();
        }


        /// <summary>
        ///     Retorna um livro de id específico
        /// </summary>
        /// <remarks>
        ///     GET: api/v2/livro/getby/{id}
        /// </remarks> 
        /// <response code="400"> Se não encontrar nenhum Id correspondente </response>
        [HttpGet]
        [Route("getBy/{id}")]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<Livro>> GetLivroById(long id)
        {
            var livro = await _context.Livro.FindAsync(id);

            if (livro == null)
            {
                return NotFound();
            }

            return livro;
        }



        /// <summary>
        ///     Edita um livro específico passando o Id
        /// </summary>
        /// <remarks>
        ///     PUT: api/v2/livro/editar/{id}
        /// </remarks>
        /// <response code="204"> Solicitação Bem sucedida error</response>
        /// <response code="400"> Se não encontrar nenhum Id correspondente </response>
        [HttpPut]
        [Route("editar/{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> PutLivro(long id, Livro livro)
        {
            if (id != livro.Id)
            {
                return BadRequest();
            }

            _context.Entry(livro).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LivroExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        /// <summary>
        ///     Cadastra um novo livro
        /// </summary>
        /// <remarks>
        ///     POST: api/v2/livro/edit/{id}
        /// </remarks>
        /// 
        [HttpPost]
        [Route("incluir")]
        [CustomModelStateValidation]
        public async Task<ActionResult<Livro>> PostLivro(Livro livro)
        {
            
            _context.Livro.Add(livro);
            await _context.SaveChangesAsync();
            
            return CreatedAtAction(nameof(GetLivroById), new { id = livro.Id }, livro);
        }

        // DELETE: api/LivroesDB/5
        /// <summary>
        ///     Remove um livro específico passando o Id
        /// </summary>
        /// <remarks>
        ///     DELETE: api/v2/livro/excluir/{id}
        /// </remarks>
        /// 
        [HttpDelete]
        [Route("excluir/{id}")]
        public async Task<IActionResult> DeleteLivro(long id)
        {
            var livro = await _context.Livro.FindAsync(id);
            if (livro == null)
            {
                return NotFound();
            }

            _context.Livro.Remove(livro);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool LivroExists(long id)
        {
            return _context.Livro.Any(e => e.Id == id);
        }
    }
}

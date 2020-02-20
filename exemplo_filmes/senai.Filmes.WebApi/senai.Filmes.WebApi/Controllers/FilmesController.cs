using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using senai.Filmes.WebApi.Domains;
using senai.Filmes.WebApi.Interfaces;
using senai.Filmes.WebApi.Repositories;

namespace senai.Filmes.WebApi.Controllers
{
    [Produces("application/json")]

    [Route("api/[controller]")]

    [ApiController]
    public class FilmesController : ControllerBase
    {

        private IFilmesRepository _filmeRepository { get; set; }

        public FilmesController()
        {
            _filmeRepository = new FilmesRepository();
        }

        [HttpGet]
        public IEnumerable<FilmeDomain> Get()
        {
            return _filmeRepository.Listar();
        }

        [HttpGet("{id}")]
        public IActionResult SearchbyId(int id)
        {
            FilmeDomain filmeDesejado = _filmeRepository.SearchbyId(id);

            if (filmeDesejado == null)
            {
                return NotFound("Nenhum gênero encontrado");
            }

            return Ok(filmeDesejado);
        }

        [HttpPost]
        public IActionResult Register(FilmeDomain novoFilme)
        {
            _filmeRepository.Register(novoFilme);

            return StatusCode(201);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateUrl(int id, FilmeDomain filmeAtualizado)
        {

            FilmeDomain filmeReferencia = _filmeRepository.SearchbyId(id);

            if (filmeReferencia == null)
            {
                return NotFound
                    (
                        new
                        {
                            mensagem = "Gênero não Encontrado",
                            erro = true
                        }

                    );
            }

            try
            {

                _filmeRepository.UpdateUrl(id, filmeAtualizado);

                return NoContent();
            }
            catch (Exception erro)
            {
                return BadRequest(erro);
            }

        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _filmeRepository.Delete(id);

            return Ok("Gênero Deletado");
        }






    }
}
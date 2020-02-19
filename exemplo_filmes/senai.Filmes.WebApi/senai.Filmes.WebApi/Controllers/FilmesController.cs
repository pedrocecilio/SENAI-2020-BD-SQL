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

        [HttpGet("{id}"]
        public IActionResult SearchbyId(int id)
        {
            FilmeDomain filmeDesejado = _filmeRepository.SearchbyId(id);

            if(filmeDesejado == null)
        }
    }
}
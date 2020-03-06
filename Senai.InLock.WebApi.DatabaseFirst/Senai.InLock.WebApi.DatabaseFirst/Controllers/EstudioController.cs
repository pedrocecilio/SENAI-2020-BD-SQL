using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Senai.InLock.WebApi.DatabaseFirst.Domains;
using Senai.InLock.WebApi.DatabaseFirst.Interfaces;
using Senai.InLock.WebApi.DatabaseFirst.Repositories;

namespace Senai.InLock.WebApi.DatabaseFirst.Controllers
{
    
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class EstudioController : ControllerBase
    {
        private IEstudioRepository _estudioRepository;

        /// <summary>
        /// Instancia este objeto para que haja a referência aos métodos no repositório
        /// </summary>
        public EstudioController()
        {
            _estudioRepository = new EstudioRepository();
        }

        /// <summary>
        /// Lista todos os estúdios
        /// </summary>
        /// <returns>Uma lista de estúdios e um status code 200 - Ok</returns>
        [HttpGet]
        public IActionResult Listar()
        {
            // Retora a resposta da requisição fazendo a chamada para o método
            return Ok(_estudioRepository.Listar());
        }

        /// <summary>
        /// Busca um estúdio através do ID
        /// </summary>
        /// <param name="id">ID do estúdio que será buscado</param>
        /// <returns>Um estúdio buscado e um status code 200 - Ok</returns>
        [HttpGet("{id}")]
        public IActionResult BuscaporId(int id)
        {
            // Retora a resposta da requisição fazendo a chamada para o método
            return Ok(_estudioRepository.BuscarPorId(id));
        }

        /// <summary>
        /// Cadastra um novo estúdio
        /// </summary>
        /// <param name="novoEstudio">Objeto novoEstudio que será cadastrado</param>
        /// <returns>Um status code 201 - Created</returns>
        [HttpPost]
        public IActionResult Cadastrar(Estudio novoEstudio)
        {
            // Faz a chamada para o método
            _estudioRepository.Cadastrar(novoEstudio);

            // Retorna um status code
            return StatusCode(201);
        }

        [HttpPut("{id}")]
        public IActionResult Atualizar(int id, Estudio estudioAtualizado)
        {
            Estudio estudioBuscado = _estudioRepository.BuscarPorId(id);
            if (estudioBuscado != null)
            {

                try
                {

                    _estudioRepository.Atualizar(id, estudioAtualizado);


                    return NoContent();
                }

                catch (Exception erro)
                {

                    return BadRequest(erro);
                }

            }


            return NotFound
                (
                    new
                    {
                        mensagem = "Estudio não encontrado",
                        erro = true
                    }
                );
        }

        [HttpDelete("{id}")]
        public IActionResult Deletar(int id)
        {
            Estudio estudioBuscado = _estudioRepository.BuscarPorId(id);


            if (estudioBuscado != null)
            {

                _estudioRepository.Deletar(id);


                return Ok($"O estudio {id} foi deletado com sucesso!");
            }


            return NotFound("Nenhum estudio encontrado para o identificador informado");
        }

      
      

    }
        


     

    
}
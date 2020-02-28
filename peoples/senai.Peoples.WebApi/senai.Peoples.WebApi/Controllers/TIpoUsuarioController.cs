using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using senai.Peoples.WebApi.Domains;
using senai.Peoples.WebApi.Interfaces;
using senai.Peoples.WebApi.Repositories;

namespace senai.Peoples.WebApi.Controllers
{
    [Produces ("application/json")]

    [Route("api/[controller]")]

    [ApiController]
    public class TipoUsuarioController : ControllerBase
    {

        private ITipoUsuarioRepository _tipoUsuarioRepository { get; set; }

        public TipoUsuarioController()
        {
            _tipoUsuarioRepository = new TipoUsuarioRepository();
        }


        [HttpGet]
        public IEnumerable<TipoUsuarioDomain> Get()
        {
            return _tipoUsuarioRepository.Listar();
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            // Cria um objeto generoBuscado que irá receber o gênero buscado no banco de dados
            TipoUsuarioDomain tipoBuscado = _tipoUsuarioRepository.BuscarPorId(id);

            // Verifica se nenhum gênero foi encontrado
            if (tipoBuscado == null)
            {
                // Caso não seja encontrado, retorna um status code 404 com a mensagem personalizada
                return NotFound("Nenhum gênero encontrado");
            }

            // Caso seja encontrado, retorna o gênero buscado
            return Ok(tipoBuscado);
        }

        [HttpPut("{id}")]
        public IActionResult PutIdUrl(int id, TipoUsuarioDomain tipoAtualizado)
        {
            // Cria um objeto generoBuscado que irá receber o gênero buscado no banco de dados
            TipoUsuarioDomain tipoBuscado = _tipoUsuarioRepository.BuscarPorId(id);

            // Verifica se nenhum gênero foi encontrado
            if (tipoBuscado == null)
            {
                // Caso não seja encontrado, retorna NotFound com uma mensagem personalizada
                // e um bool para representar que houve erro
                return NotFound
                    (
                        new
                        {
                            mensagem = "Tipo não encontrado",
                            erro = true
                        }
                    );
            }

            // Tenta atualizar o registro
            try
            {
                // Faz a chamada para o método .AtualizarIdUrl();
                _tipoUsuarioRepository.AtualizarIdUrl(id, tipoAtualizado);

                // Retorna um status code 204 - No Content
                return NoContent();
            }
            // Caso ocorra algum erro
            catch (Exception erro)
            {
                // Retorna BadRequest e o erro
                return BadRequest(erro);
            }
        }


        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            // Faz a chamada para o método .Deletar();
            _tipoUsuarioRepository.Deletar(id);

            // Retorna um status code com uma mensagem personalizada
            return Ok("TipoUsuario deletado");
        }


    }
}
using Senai.InLock.WebApi.DatabaseFirst.Domains;
using Senai.InLock.WebApi.DatabaseFirst.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.InLock.WebApi.DatabaseFirst.Repositories
{
    public class EstudioRepository : IEstudioRepository

    {
        /// <summary>
        /// Objeto contexto por onde serão chamados os métodos do EF Core
        /// </summary>
        InLockContext ctx = new InLockContext();
        Estudio estudioBuscado = new Estudio();

        public void Atualizar(int id, Estudio estudioAtualizado)
        {
            estudioBuscado = ctx.Estudio.FirstOrDefault(e => e.IdEstudio == id);

            estudioBuscado.NomeEstudio = estudioAtualizado.NomeEstudio;

            ctx.Estudio.Update(estudioBuscado);

            ctx.SaveChanges();
        }

        /// <summary>
        /// Busca um estúdio através do ID
        /// </summary>
        /// <param name="id">ID do estúdio que será buscado</param>
        /// <returns>Um estúdio buscado</returns>
        public Estudio BuscarPorId(int id)
        {
            // Retorna o primeiro estúdio encontrado para o ID informado
            return ctx.Estudio.FirstOrDefault(e => e.IdEstudio == id);
        }

        /// <summary>
        /// Cadastra um novo estúdio
        /// </summary>
        /// <param name="novoEstudio">Objeto novoEstudio que será cadastrado</param>
        public void Cadastrar(Estudio novoEstudio)
        {
            // Adiciona este novoEstudio
            ctx.Estudio.Add(novoEstudio);
            // Salva as informações para serem gravadas no banco de dados
            ctx.SaveChanges();
        }
        
        public void Deletar(int id)
        {
                    
            estudioBuscado = ctx.Estudio.FirstOrDefault(e => e.IdEstudio == id);

            ctx.Estudio.Remove(estudioBuscado);

            ctx.SaveChanges();
        }
        
        /// <summary>
        /// Lista todos os estúdios
        /// </summary>
        /// <returns>Uma lista de estúdios</returns>
        public List<Estudio> Listar()
        {
            // Retorna uma lista com todas as informações dos estúdios
            return ctx.Estudio.ToList();
        }
    }
}

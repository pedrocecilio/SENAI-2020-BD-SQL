using Senai.Gufi.WebApi.Manha.Domains;
using Senai.Gufi.WebApi.Manha.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.Gufi.WebApi.Manha.Repositories
{
    public class UsuairoRepository : IUsuarioRepository
    {
        GufiContext ctx = new GufiContext();

        public void Atualizar(int id, Usuarios usuarioAtualziado)
        {
            Usuario usuarioBuscado = ctx.Usuario.Find(id);
            
            //usuarioBuscado.
        }

        public Usuarios BuscarPorId(int id)
        {
            throw new NotImplementedException();
        }

        public void Cadastrar(Usuarios novoUsuario)
        {
            throw new NotImplementedException();
        }

        public void Deletar(int id)
        {
            throw new NotImplementedException();
        }

        public List<Usuarios> Listar()
        {
            throw new NotImplementedException();
        }
    }
}

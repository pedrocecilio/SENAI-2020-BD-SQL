using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.Gufi.WebApi.Manha.Interfaces
{
    interface IUsuarioRepository
    {
        List<Usuarios> Listar();

        void Cadastrar(Usuarios novoUsuario);

        void Atualizar(int id, Usuarios usuarioAtualziado);

        void Deletar(int id);

        Usuarios BuscarPorId(int id);
    }
}

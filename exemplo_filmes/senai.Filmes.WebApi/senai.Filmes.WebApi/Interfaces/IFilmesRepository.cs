using senai.Filmes.WebApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai.Filmes.WebApi.Interfaces
{
    interface IFilmesRepository
    {

        List<FilmeDomain> Listar();

        GeneroDomain SearchbyId(int id);







    }
}

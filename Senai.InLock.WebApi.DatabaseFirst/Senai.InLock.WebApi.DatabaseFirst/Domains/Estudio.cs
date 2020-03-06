using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Senai.InLock.WebApi.DatabaseFirst.Domains
{
    public partial class Estudio
    {
        public Estudio()
        {
            Jogos = new HashSet<Jogos>();
        }

        public int IdEstudio { get; set; }
        [Required(ErrorMessage = "O nome do estúdio é obrigatório!")]
        public string NomeEstudio { get; set; }

        public ICollection<Jogos> Jogos { get; set; }
    }
}

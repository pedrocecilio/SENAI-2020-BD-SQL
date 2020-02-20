using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Senai.Peoples.WebApi.Interfaces;

namespace Senai.Peoples.WebApi.Controllers
{
    [Produces("application/json")]

    [Route("api/[controller]")]

    [ApiController]

    public class FuncionarioController : ControllerBase
    {

        private IFuncionarioRepository _funcionarioRepository { get; set; }


        public FuncionariosController()
        {
            _funcionarioRepository = new FuncionarioController();
        }

    }
}
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MiPrimerWebApi9.Entities;
using MiPrimerWebApi9.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MiPrimerWebApi9.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AutoresController : ControllerBase
    {
        private readonly IRepositorioAutores repositorioAutores;

        public AutoresController(IRepositorioAutores repositorioAutores)
        {
            this.repositorioAutores = repositorioAutores;
        }

        [HttpGet("{id}")]
        [Authorize]
        public ActionResult<Autor> Get(int id)
        {
            if(User.Identity.IsAuthenticated)
            {
                var claims = User.Claims;
            }

            var autor = repositorioAutores.ObtenerPorId(id);

            if (autor == null)
            {
                return NotFound();
            }

            return autor;
        }
    }
}

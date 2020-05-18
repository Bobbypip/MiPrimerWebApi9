using MiPrimerWebApi9.Contexts;
using MiPrimerWebApi9.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MiPrimerWebApi9.Services
{
    public class RepositorioAutores : IRepositorioAutores
    {
        private readonly ApplicationDbContext context;

        public RepositorioAutores(ApplicationDbContext context)
        {
            this.context = context;
        }

        public Autor ObtenerPorId(int id)
        {
            return context.Autores.FirstOrDefault(x => x.Id == id);
        }
    }
}

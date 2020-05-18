using MiPrimerWebApi9.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MiPrimerWebApi9.Services
{
   public interface IRepositorioAutores
    {
        Autor ObtenerPorId(int id);
    }
}

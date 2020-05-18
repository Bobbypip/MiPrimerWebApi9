﻿using Microsoft.EntityFrameworkCore;
using MiPrimerWebApi9.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MiPrimerWebApi9.Contexts
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }

        public DbSet<Autor> Autores { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            var autores = new List<Autor>()
            {
                new Autor(){Id = 1, Nombre = "Felipe Gavilán" },
                new Autor(){Id = 2, Nombre = "Claudia Rodríguez" }
            };

            modelBuilder.Entity<Autor>().HasData(autores);

            var libros = new List<Libro>()
            {
                new Libro(){Id = 1, Titulo = "Entity Framework Core 2.1 - De verdad", AutorId = 1},
                new Libro(){Id = 2, Titulo = "Construyendo Web APIs con ASP.NET Core 2.2", AutorId = 2},
                new Libro(){Id = 3, Titulo = "Libro de prueba", AutorId = 2}
            };

            modelBuilder.Entity<Libro>().HasData(libros);


        }

    }
}

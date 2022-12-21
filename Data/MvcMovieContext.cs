using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MvcMovie.Models.Categoria;
using MvcMovie.Models.Produtos;
using MvcMovie.Models.Clientes;

namespace MvcMovie.Data
{
    public class MvcMovieContext : DbContext
    {
        public MvcMovieContext (DbContextOptions<MvcMovieContext> options)
            : base(options)
        {
        }

        public DbSet<Categoria>? Categoria { get; set; }

        public DbSet<Produtos>? Produtos { get; set; }

        public DbSet<Clientes>? Clientes { get; set; }
    }
}

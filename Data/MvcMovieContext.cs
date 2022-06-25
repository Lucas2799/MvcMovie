using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MvcMovie.Models.Categoria;
using MvcMovie.Models.Produtos;

namespace MvcMovie.Data
{
    public class MvcMovieContext : DbContext
    {
        public MvcMovieContext (DbContextOptions<MvcMovieContext> options)
            : base(options)
        {
        }

        public DbSet<MvcMovie.Models.Categoria.Categoria>? Categoria { get; set; }

        public DbSet<MvcMovie.Models.Produtos.Produtos>? Produtos { get; set; }
    }
}

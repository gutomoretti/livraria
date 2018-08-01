using Livraria.Application.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Livraria.Application.Context
{
    public class LivrariaContext : DbContext
    {
        public LivrariaContext()
        {

        }

        public DbSet<Livro> livro { get; set; }
        public DbSet<Genero> genero { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.\\\\SQLEXPRESS;Database=livraria;User Id=sa;Password=123;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Livro>()
                    .HasKey(r => r.Id);

                    modelBuilder.Entity<Genero>()
                    .HasKey(r => r.IdGenero);
        }

    }
}

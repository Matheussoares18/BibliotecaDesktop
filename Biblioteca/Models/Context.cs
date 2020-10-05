using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteca.Models
{
    class Context : DbContext
    {
        public DbSet<Cliente> Cliente { get; set; }

        public DbSet<Funcionario> Funcionarios { get; set; }

        public DbSet<Livro> Livro { get; set; }

        public DbSet<Emprestimo> Emprestimo { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=localhost;Database=Biblioteca;Trusted_Connection=true");
        }

    }
}

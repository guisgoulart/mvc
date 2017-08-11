using COREteste3.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace COREteste3.Controllers
{
    internal class LojaContext : DbContext
    {

        public DbSet<Produto>Produtos { get; set; } //Produtos porque é o nome da tabela, Produto é o objeto

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=LojaDB;Trusted_Connection=true;");
        }

    }
}
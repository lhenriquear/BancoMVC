using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BancoMVC.Models
{
    public class Context : DbContext
    {

        public DbSet<Usuario> Usuarios { get; set; }

        public DbSet<Conta> Contas { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Bancomvc;Integrated Security = true");
        }
    }
}

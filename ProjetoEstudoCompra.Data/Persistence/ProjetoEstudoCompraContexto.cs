using Microsoft.EntityFrameworkCore;
using ProjetoEstucoCompra.Entidade.Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEstudoCompra.Data.Persistence
{
    public class ProjetoEstudoCompraContexto : DbContext
    {
        public ProjetoEstudoCompraContexto()
        {

        }

        public ProjetoEstudoCompraContexto(DbContextOptions option)
            : base(option)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Login>().ToTable("Login");
            modelBuilder.Entity<Login>().HasKey(l => l.LoginId).IsClustered();
            modelBuilder.Entity<Login>().Property(l => l.Usuario).IsRequired();
            modelBuilder.Entity<Login>().Property(l => l.Senha).IsRequired();
            modelBuilder.Entity<Login>().Property(l => l.Perfil).IsRequired();
            modelBuilder.Entity<Login>().Property(l => l.Email).IsRequired();

        }

        public DbSet<Login> logins { get; set; }
    }
}

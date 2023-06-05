using Microsoft.EntityFrameworkCore;
using ProjetoEstucoCompra.Entidade.Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEstudoCompra.Data.Migration
{
    public class LoginMapping
    {
        public void OnModelCreate(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Login>().ToTable("Login");
            modelBuilder.Entity<Login>().HasKey(l => l.LoginId).IsClustered();
            modelBuilder.Entity<Login>().Property(l => l.Usuario).IsRequired();
            modelBuilder.Entity<Login>().Property(l => l.Senha).IsRequired();
            modelBuilder.Entity<Login>().Property(l => l.Email).IsRequired();
            modelBuilder.Entity<Login>().Property(l => l.Perfil).IsRequired();

        }
    }
}

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

        public DbSet<Login> logins { get; set; }
    }
}

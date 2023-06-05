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
        private DbContextOptionsBuilder options;

        public ProjetoEstudoCompraContexto(DbContextOptions option)
            : base(option)
        {

        }

        public ProjetoEstudoCompraContexto(DbContextOptionsBuilder options)
        {
            this.options = options;
        }

        public DbSet<Login> logins { get; set; }
    }
}

using Microsoft.EntityFrameworkCore;
using ProjetoEstucoCompra.Entidade.Entidade;
using ProjetoEstudoCompra.Data.Persistence;
using ProjetoEstudoCompra.Data.Repositorio.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEstudoCompra.Data.Repositorio
{
    public class LoginRepositorio : ILoginRepositorio
    {
        private readonly ProjetoEstudoCompraContexto _db;

        public LoginRepositorio()
        {
            var options = new DbContextOptionsBuilder();
            _db = new ProjetoEstudoCompraContexto(options);
        }

        public void Cadastrar(Login login)
        {
            _db.Add(login);
        }
    }
}

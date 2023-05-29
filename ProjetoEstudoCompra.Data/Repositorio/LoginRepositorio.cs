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
            _db = new ProjetoEstudoCompraContexto();
        }

        public void Cadastrar(Login login)
        {
            _db.logins.Add(login);
        }
    }
}

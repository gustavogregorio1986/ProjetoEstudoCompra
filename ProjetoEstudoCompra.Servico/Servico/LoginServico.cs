using ProjetoEstucoCompra.Entidade.Entidade;
using ProjetoEstudoCompra.Data.Repositorio;
using ProjetoEstudoCompra.Servico.Servico.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEstudoCompra.Servico.Servico
{
    public class LoginServico : ILoginServico
    {
        private readonly LoginRepositorio loginRepositorio;

        public LoginServico()
        {
            loginRepositorio = new LoginRepositorio();
        }

        public void Cadastrar(Login login)
        {
            loginRepositorio.Cadastrar(login);
        }
    }
}

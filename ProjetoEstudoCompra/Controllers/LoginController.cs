using Microsoft.AspNetCore.Mvc;
using ProjetoEstucoCompra.Entidade.Entidade;
using ProjetoEstudoCompra.Models;
using ProjetoEstudoCompra.Servico.Servico;

namespace ProjetoEstudoCompra.Controllers
{
    public class LoginController : Controller
    {
        private readonly LoginServico loginServico;

        public LoginController()
        {
            loginServico = new LoginServico();
        }

        public IActionResult Cadastrar()
        {
            return View();
        }

        public IActionResult CadastrarLogin(LoginView loginView)
        {
            loginView = new LoginView();
            Login login = new Login();
            loginView.Usuario = login.Usuario;
            loginView.Senha = login.Senha;
            loginView.Email = login.Email;
            loginView.Perfil = login.Perfil;
            loginServico.Cadastrar(login);
            return View(login);
        }
    }
}

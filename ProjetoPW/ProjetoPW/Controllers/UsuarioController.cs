using Microsoft.AspNetCore.Mvc;
using ProjetoPW.Models;
using ProjetoPW.Repository.Contract;

namespace ProjetoPW.Controllers
{
    public class UsuarioController : Controller
    {
        private IUsuarioRepository _usuarioRepository;

        public UsuarioController(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CadastrarUsuario()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CadastrarUsuario(Usuario usuario)
        {
            if(ModelState.IsValid)
            {
                _usuarioRepository.Cadastrar(usuario);
            }
            return View();
        }
       
    }

}

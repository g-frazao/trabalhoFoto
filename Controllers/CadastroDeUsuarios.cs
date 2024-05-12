using Microsoft.AspNetCore.Mvc;
using trabalhoFoto.Models;

namespace trabalhoFoto.Controllers
{
    public class CadastroDeUsuarios : Controller
    {
        public IActionResult Casdastro()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Cadastro(Usuario usuario)
        {
            return RedirectToAction("Index", "Home");
        }
    }
}

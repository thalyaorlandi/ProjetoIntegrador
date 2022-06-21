using Microsoft.AspNetCore.Mvc;

namespace ProjetoIntegrador.Controllers
{
    public class OrganizadorController : Controller
    {
        public IActionResult Entrar()
        {
            return View();
        }

        public IActionResult Autenticar(string codigo)
        {
            if (codigo == "gettogether")
            {
                return RedirectToAction("Adicionar", "Evento");
            }
            else
            {
                return View("CodigoInvalido");
            }
        }
    }
}

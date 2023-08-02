using Microsoft.AspNetCore.Mvc;


namespace PAWS_ProyectoFinal.Controllers
{
    public class InicioSesionController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult validacion()
        {

            return RedirectToAction("Index","Home");

        }
    }


}

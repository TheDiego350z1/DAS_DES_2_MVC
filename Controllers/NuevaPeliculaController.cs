using Microsoft.AspNetCore.Mvc;

namespace DAS_DES_2_MVC.Controllers
{
    public class NuevaPeliculaController:Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
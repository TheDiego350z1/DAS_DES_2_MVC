using Microsoft.AspNetCore.Mvc;

namespace DAS_DES_2_MVC.Controllers
{
    public class PeliculasController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        
    }
}
using Microsoft.AspNetCore.Mvc;

namespace Practica2.Controllers
{
    public class VentaController
    {
        public class Venta : Controller
        {
            public IActionResult Index()
            {
                return View();
            }
        } 
    }
}
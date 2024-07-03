using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TP5___Sala_de_escape.Models;

namespace TP5___Sala_de_escape.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Tutorial()
        {
            return View();
        }

        public IActionResult Comenzar()
        {
            return View();
        }

        public IActionResult Habitacion(int sala, string clave)
        {
            string habitacion = "HabitacionX";
            
            if (sala != Escape.GetEstadoJuego())
            {
                return RedirectToAction("Comenzar"); 
            }
            else
            {
                if (!Escape.ResolverSala(sala, clave))
                {
                    ViewBag.Error = "La respuesta escrita fue incorrecta."; 
                }
                else if(Escape.GetEstadoJuego() > 4){
                    habitacion = "Victoria";
                }
            }
            habitacion.Replace('X', (char)Escape.GetEstadoJuego());
            return View(habitacion);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

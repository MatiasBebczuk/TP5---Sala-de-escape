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
            Escape.Reset();
            return View();
        }
        public IActionResult Creditos()
        {
            return View();
        }

        public IActionResult Tutorial()
        {
            return View();
        }

        public IActionResult Comenzar()
        {
            return View("Habitacion1");
        }

        public IActionResult Habitacion(int sala, string clave)
        {
            string habitacion = "Habitacion";
            bool salaResuelta = Escape.ResolverSala(sala, clave);
            
            if (sala != Escape.GetEstadoJuego() - 1)
            {
                return RedirectToAction("Comenzar");
            }
            else
            {
                if (!salaResuelta)
                {
                    ViewBag.Error = "La respuesta escrita fue incorrecta."; 
                }
                else if(Escape.GetEstadoJuego() > 4){
                    habitacion = "Victoria";
                }
            }
            habitacion += Escape.GetEstadoJuego();
            Console.WriteLine(habitacion);
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
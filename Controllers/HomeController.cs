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

        public IActionResult Comenzar(int tiemp)
        {
            ViewBag.tiemp = tiemp;
            return View("Habitacion1");
        }

        public IActionResult Habitacion(int sala, string clave)
        {
            string habitacion = "Habitacion";
            bool salaResuelta = Escape.ResolverSala(sala, clave);
            
            if (sala != Escape.GetEstadoJuego())
            {
                return View((habitacion + Escape.GetEstadoJuego()));
            }
            else 
            {
                if (!salaResuelta)
                {
                    ViewBag.Error = "La respuesta escrita fue incorrecta.";
                }
                else if (Escape.GetEstadoJuego() == 4)
                {
                    habitacion = "Victoria";
                    ViewBag.cantIntentos = Escape.cantIntentos;
                    ViewBag.cantPistas = Escape.cantPistas;
                }
                else{
                    Escape.AumentarEstadoJuego();
                }
            }
            if(habitacion != "Victoria"){ habitacion += Escape.GetEstadoJuego(); }
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

        public IActionResult Derrota()
        {
            return View();
        }
    }
}
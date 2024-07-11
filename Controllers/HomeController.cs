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
            if (Escape.IsGameOver())
            {
                return RedirectToAction("Derrota");
            }
            ViewBag.RemainingTime = Escape.GetRemainingTime();
            return View();
        }

        public IActionResult Creditos()
        {
            if (Escape.IsGameOver())
            {
                return RedirectToAction("Derrota");
            }

            ViewBag.RemainingTime = Escape.GetRemainingTime();
            return View();
        }

        public IActionResult Tutorial()
        {
            if (Escape.IsGameOver())
            {
                return RedirectToAction("Derrota");
            }

            ViewBag.RemainingTime = Escape.GetRemainingTime();
            return View();
        }

        public IActionResult Comenzar()
        {
            if (Escape.IsGameOver())
            {
                return RedirectToAction("Derrota");
            }

            ViewBag.RemainingTime = Escape.GetRemainingTime();
            return View("Habitacion1");
        }

        public IActionResult Habitacion(int sala, string clave)
        {
            if (Escape.IsGameOver())
            {
                return RedirectToAction("Derrota");
            }
            string habitacion = "Habitacion";
            bool salaResuelta = Escape.ResolverSala(sala, clave);
            
            if (sala != Escape.GetEstadoJuego() - 1)
            {
                return View((habitacion + Escape.GetEstadoJuego()));
            }
            else 
            {
                if (!salaResuelta)
                {
                    ViewBag.Error = "La respuesta escrita fue incorrecta.";
                }
                else if (Escape.GetEstadoJuego() > 4)
                {
                    habitacion = "Victoria";
                    Escape.StopGame();
                }
            }
            if(habitacion != "Victoria"){ habitacion += Escape.GetEstadoJuego(); }
            ViewBag.RemainingTime = Escape.GetRemainingTime();
            Console.WriteLine(habitacion);
            return View(habitacion);
        }

        public IActionResult Privacy()
        {
            if (Escape.IsGameOver())
            {
                return RedirectToAction("Derrota");
            }

            ViewBag.RemainingTime = Escape.GetRemainingTime();
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
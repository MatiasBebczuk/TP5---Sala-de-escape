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

            string habitacion = "HabitacionX";
            bool salaResuelta = Escape.ResolverSala(sala, clave);

            if (sala != Escape.GetEstadoJuego())
            {
                return RedirectToAction("Comenzar");
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
            habitacion = habitacion.Replace('X', Escape.GetEstadoJuego().ToString());
            ViewBag.RemainingTime = Escape.GetRemainingTime();
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

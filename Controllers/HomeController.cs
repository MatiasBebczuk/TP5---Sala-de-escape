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
<<<<<<< HEAD
            if (Escape.IsGameOver())
            {
                return RedirectToAction("Derrota");
            }

            ViewBag.RemainingTime = Escape.GetRemainingTime();
=======
            Escape.Reset();
>>>>>>> d3e522f5c2d7086898223ae606f79bd0a34f8a2d
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
<<<<<<< HEAD
            if (Escape.IsGameOver())
            {
                return RedirectToAction("Derrota");
            }

            string habitacion = "HabitacionX";
            bool salaResuelta = Escape.ResolverSala(sala, clave);

            if (sala != Escape.GetEstadoJuego())
=======
            string habitacion = "Habitacion";
            bool salaResuelta = Escape.ResolverSala(sala, clave);
            
            if (sala != Escape.GetEstadoJuego() - 1)
>>>>>>> d3e522f5c2d7086898223ae606f79bd0a34f8a2d
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
<<<<<<< HEAD
            habitacion = habitacion.Replace('X', Escape.GetEstadoJuego().ToString());
            ViewBag.RemainingTime = Escape.GetRemainingTime();
=======
            if(habitacion != "Victoria"){ habitacion += Escape.GetEstadoJuego(); }
            Console.WriteLine(habitacion);
>>>>>>> d3e522f5c2d7086898223ae606f79bd0a34f8a2d
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
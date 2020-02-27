using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Ejercicio_1.Models;
using Ejercicio_1.Helpers;

namespace Ejercicio_1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Valores a)
        {
            return RedirectToAction("Presentar", a);
        }

        public IActionResult Presentar(Valores a)
        {
            List<int> numeros = new List<int>();
            numeros.Add(a.valor0);
            numeros.Add(a.valor1);
            numeros.Add(a.valor2);
            numeros.Add(a.valor3);
            numeros.Add(a.valor4);
            numeros.Add(a.valor5);
            numeros.Add(a.valor6);
            numeros.Add(a.valor7);
            numeros.Add(a.valor8);
            numeros.Add(a.valor9);

            for (int i = 0; i < 10; i++)
            {
                numeros[i] = (Helper.transformar(numeros[i]));
            }

            return View(numeros);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

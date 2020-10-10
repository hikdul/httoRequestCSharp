using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _0._8HTTPRequest.helpers;
using _0._8HTTPRequest.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace _0._8HTTPRequest.Controllers
{
    public class test2Controller : Controller
    {
        public IActionResult Index()
        {
            test2 datos1 = new test2();
            string url = "https://geocode.xyz/Hauptstr.,+57632+Caracas?json=1";
            string respuesta = HttpSolicitudes.GetHTTP(url);
            datos1 = JsonConvert.DeserializeObject<test2>(respuesta);

            return View(datos1);
        }
      

    }
}

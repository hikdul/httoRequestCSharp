using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.IO;
using _0._8HTTPRequest.Models;
using _0._8HTTPRequest.helpers;
using Newtonsoft.Json;

namespace _0._8HTTPRequest.Controllers
{
    public class Test1Controller : Controller
    {
        private readonly string ControladorAPI = "https://localhost:44306/api/test1api";
        public IActionResult Index()
        {
            string json = HttpSolicitudes.GetHTTP(ControladorAPI);
            List<test1> Lista = new List<test1>();
            Lista = JsonConvert.DeserializeObject<List<test1>>(json);
            return View(Lista);
        }

        public IActionResult Nuevo()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Nuevo(test1 insert)
        {
            try
            {
                string json = JsonConvert.SerializeObject(insert);
                var respuesta = HttpSolicitudes.PostHTTP<test1>(ControladorAPI, json);
                return RedirectToAction("Index");
            }
            catch
            {
                return View(insert);
            }


        }

    }
}

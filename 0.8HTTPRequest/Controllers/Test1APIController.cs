using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _0._8HTTPRequest.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace _0._8HTTPRequest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Test1APIController : ControllerBase
    {
        [HttpGet]
        public  List<test1> GetAll()
        {
            List<test1> lista = new List<test1>();

            lista.Add(new test1()
            {
                id = 1,
                Groceria = "Marico"
            });

            lista.Add(new test1()
            {
                id = 2,
                Groceria = "Parchita"
            });

            lista.Add(new test1()
            {
                id = 3,
                Groceria = "Rosca Dulce"
            });

            return lista;

        }

        [HttpGet("{id}")]
        public test1 GetID(int id)
        {
            return new test1()
            {
                id = id,
                Groceria = "Marico no hay cambio solo es un test"
            };
        }

        [HttpPost]
        public bool Post([FromBody]test1 insert)
        {
            if (insert != null)
                return true;
            return false;

        }


    }
}

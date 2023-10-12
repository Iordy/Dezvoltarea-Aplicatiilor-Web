using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Lab2.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Lab2
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        public static List<Excavator> Utilaje = new List<Excavator> ()
        {
            new Excavator { id = 1, age = 10, tonaj = 40 },
             new Excavator { id = 2, age = 12, tonaj = 30 },
              new Excavator { id = 3, age = 8, tonaj = 25 },
               new Excavator { id = 4, age = 15, tonaj = 45 },
                new Excavator { id = 5, age = 11, tonaj = 60 }

        };


        [HttpGet]
        public List<Excavator> Get()
        {
            return Utilaje;
        }
    };

  


}


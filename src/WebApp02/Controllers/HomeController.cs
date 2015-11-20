using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using Microsoft.Extensions.OptionsModel;
using WebApp02.Models;

namespace WebApp02.Controllers
{
    public class HomeController : Controller
    {
        /// <summary>
        /// this will show how to pass the configuration from Startup.cs
        /// we could even pass this object into our View
        /// </summary>
        public HomeController(IOptions<Startup.MyOptions> o)
        {
            var foo = o.Value.color;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Foo()
        {
            return View();
        }

        [HttpPost]
        public IActionResult About(Person personIn)
        {
            // DO SOME STUFF

            return View(personIn);
        }

        // GET /HOME/ABOUT
        [HttpGet]
        public IActionResult About()
        {
            ViewData["Message"] = "Here is a person";
            var person = new Person()
            {
                FirstName = "Andre",
                LastName = "Roussakoff",
                Birthdate = new DateTime(1958, 4, 30)
            };

            return View(person); // assumes /home/about but we could pass another as a parameter
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View("~/Views/Shared/Error.cshtml");
        }
    }
}

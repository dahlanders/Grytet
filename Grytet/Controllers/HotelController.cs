using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Grytet.Domain;

namespace Grytet.Controllers
{
    [Route("Api")]
    public class HotelController : Controller
    {
        [HttpPost, Route("Seed")]
        public IActionResult Seed()
        {
            var nyhet1 = new Areas();
            {
                nyhet1.Header = "Kodningen går åt helvete";
                nyhet1.Body = "Vi har lösningen";
            }


            var nyhet2 = new News();
            {
                nyhet2.Header = "Kodningen går bra";
                nyhet2.Body = "Vi löser nog inte detta";
                nyhet2.Intro = "Frukten är avgörande att kodningen går bra. Vi tror på ett ökat intag säger läraren.";
            }
        }
    }
}
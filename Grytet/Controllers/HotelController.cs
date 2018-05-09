using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Grytet.Domain;
using Grytet.Test;

namespace Grytet.Controllers
{
    [Route("Api")]
    public class HotelController : Controller
    {
        [Route("Seed")]
        public IActionResult Seed()
        {
            return Json(TestClassTestData.Testareas());
        }
    }
}
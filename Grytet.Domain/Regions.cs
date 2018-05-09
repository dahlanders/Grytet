using System;
using System.Collections.Generic;
using System.Text;

namespace Grytet.Domain
{
    public class Regions : City
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<City> Citys { get; set; }

    }
}

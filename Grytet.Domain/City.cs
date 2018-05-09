using System;
using System.Collections.Generic;
using System.Text;

namespace Grytet.Domain
{
    public class City : Areas
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Areas> Areas { get; set; }


    }
}

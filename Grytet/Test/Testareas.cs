using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Grytet.Domain;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace Grytet.Test
{
    public class TestClassTestData
    {
        public static void Testareas()
        {
            var citygothenburg = new City();
            citygothenburg.Name = "Göteborg";
            citygothenburg.Areas = new List<Areas>()
            {
                new Areas()
                {

                    Name = "Göteborg Hissingen",
                    Value = 60,
                },
                new Areas()
                {
                    Name = "Göteborg Centrum",
                    Value = 50,
                }
                
            };
            var cityhelsingborg = new City();
            cityhelsingborg.Name = "Helsingborg";
            cityhelsingborg.Areas = new List<Areas>()
            {
                new Areas()
                {
                    Name = "Helsingborg",
                    Value = 70
                }
            };
        }
    }
}

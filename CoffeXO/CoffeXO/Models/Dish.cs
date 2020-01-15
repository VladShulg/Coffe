using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeXO.Models
{
    public class Dish
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Price { get; set; }
        public bool Sale { get; set; }
        public string Percent { get; set; }
    }
}

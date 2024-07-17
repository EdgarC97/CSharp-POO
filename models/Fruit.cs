using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO.models
{
    public class Fruit
    {
        public string? Name { get; set;}
        public string? Color { get; set; }

        public Fruit(string name, string color)
        {
            Name = name;
            Color = color;
        }
    }
}
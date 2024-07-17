using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO.models
{
    public class Apple : Fruit
    {
        public int NumberOfSeeds { get; set; }

        public Apple(string name, string color,int numberOfSeeds) : base(name,color)
        {
            NumberOfSeeds = numberOfSeeds;
        }

        public string DescribeMe => $"Hi, my name is {Name}, I'm color {Color} and I have {NumberOfSeeds} seed(s).";
        
    }
}
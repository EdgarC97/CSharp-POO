using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO.models
{
    public class Lyon : Carnivoro
    {
        public string? ColorCabello { get; set; }

       public override void MakeSound()
        {
            Console.WriteLine($"El Leon hace GRRR GRRR");
        }   
    }
} 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO.models
{
    public class Animal
    {
        public string? Name { get; set; }

        public virtual void MakeSound()
        {
            Console.WriteLine("El animal hace un sonido ");
        }

        
    }
}
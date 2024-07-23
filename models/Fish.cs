using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO.models
{
    public class Fish : Animal
    {
        public Fish() : base("Nemo", "Macho", "Payaso")
        {

        }

        public override void Movement()
        {
            base.Movement();
            Console.WriteLine("El pez nada en el agua");
        }
    }
}
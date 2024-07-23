using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO.models
{
    public class Cat : Animal
    {
        public Cat() : base("Gato","Macho","Felino")
        {

        }
        public override void MakeSound()
        {
            Console.WriteLine("El gato hace miauu ");
        }
        public override void Movement()
        {
            base.Movement();
            Console.WriteLine("El gato corre en 4 patas y trepa arboles");
        }
    }
}
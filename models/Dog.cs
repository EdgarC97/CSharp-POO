using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO.models
{
    public class Dog : Animal
    {
        public Dog(string name, string gender, string specie) : base(name, gender, specie)
        {

        }
        public override void MakeSound()
        {
            base.MakeSound();
            Console.WriteLine("El perro hace wuff ");
        }
        public override void Movement()
        {
            base.Movement();
            Console.WriteLine("El perro corre en 4 patas");
        }
    }
}
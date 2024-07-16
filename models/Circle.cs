using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO.models
{
    public class Circle//● Crea una clase Circulo con una propiedad Radio
    {
        public double Radius { get; set; }

        public Circle(double radio)
        {
            Radius = radio;
        }

        public void CalculateCircumference()
        {
            double circumference = 2 * Math.PI * Radius;
            Console.WriteLine($"La circunferencia del círculo con radio {Radius} es: {circumference:F2}");
        }
    }
}
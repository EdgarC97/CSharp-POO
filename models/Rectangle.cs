using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO.models
{
    public class Rectangle//● Crea una clase Rectangulo con propiedades Ancho y Alto.
    {
        public int Width { get; set; }
        public int Height { get; set; }

        //Constructor
        public Rectangle(int width, int height)
        {
            Width = width;
            Height = height;
        }

        public void CalculateArea()
        {
            int area = Width * Height;
            Console.WriteLine($"El area del rectangulo es --> {area}");
        }
    }
}
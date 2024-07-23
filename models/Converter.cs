using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO.models
{
    public class Converter
{
    public static void CelsiusToFahrenheit(double celsius)
    {
        double fahrenheit = (celsius * 1.8) + 32;
        System.Console.WriteLine("Fahrenheit: " + fahrenheit);
    }
}
}
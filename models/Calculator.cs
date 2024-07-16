using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO.models
{
    public class Calculator//● Crea una clase Calculadora con un método Sumar(int a, int b) que devuelva la suma de dos números
    {
        public int Sum(int x, int y)
        {
            return x + y;
        }

        public int Rest(int a, int b)
        {
            return a - b;
        }
    }
}
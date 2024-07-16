using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO.models
{
    public class Employee//● Crea una clase Empleado con propiedades Nombre, Puesto y Salario.
    {
        public string? Name { get; set; }
        public string? Charge { get; set; }
        public decimal Salary { get; set; }

        public Employee(string name, string charge, decimal salary)
        {
            Name = name.ToLower();
            Charge = charge;
            Salary = salary;
        }

        public void ShowDetails()
        {
            Console.WriteLine($"El nombre del empleado es --> {Name}\nEl cargo del empleado es --> {Charge}\nEl salario del empleado es --> {Salary:C}");
        }

    }
}
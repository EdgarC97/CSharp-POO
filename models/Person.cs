using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO.models
{
    public class Person//● Crea una clase Persona con propiedades Nombre y Edad.
    {
        public string? Name { get; set; }
        public int Age { get; set; }

        //● Crea una instancia de Persona y asigna valores a sus propiedades.
        public Person(string name, int age)
        {
            Name = name.ToLower();//Modifica la clase Persona para que el nombre siempre se almacene en minúsculas.
            Age = age;
        }

        public void Greeting()//● Añade un método Saludar() a la clase Persona que imprima "Hola, mi nombre es [Nombre]".
        {
            Console.WriteLine($"Hola, mi nombre es {Name}.");
        }
        public void ShowDetails()//● Añade un método MostrarDetalles() que imprima el nombre y la edad.
        {
            Console.WriteLine($"Hola, mi nombre es {Name} y mi edad es {Age}.");
        }

    }

}
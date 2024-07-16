using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO.models
{
    public class Student//● Crea una clase Estudiante con propiedades Nombre, Edad y Grado.

    {
        public string? Name { get; set; }
        public int Age { get; set; }
        public int Grade { get; set; }

        public Student(string name, int age, int grade)
        {
            Name = name.ToLower();
            Age = age;
            Grade = grade;
        }

        public int GetAge()
        {
            return Age;
        }
        public void SetAge(int newAge)
        {
            Age = newAge;
            Console.WriteLine($"La nueva edad del estudiante es --> {newAge}");
        }
    }
}
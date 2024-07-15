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
        public Person (string name, int age)
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

    public class Car //● Crea una clase Coche con propiedades Marca, Modelo y Año.
    {
        public string? Brand { get; set; }
        public string? Model { get; set; }
        public int Year { get; set; }


        //● Crea una instancia de Coche, asigna valores y muestra los valores en la consola.
        public Car (string brand, string model, int year)
        {
            Brand = brand;
            Model = model;
            Year = year;
        }
        //● Añade un método MostrarDetalles() a la clase Coche que imprima los detalles del coche.
        public void ShowDetails()
        {
            Console.WriteLine($"La marca del carro es: {Brand}.\nEl modelo del carro es: {Model}. \nEl año del carro es: {Year}");
        }
        //● Añade un método ActualizarAño(int nuevoAño) a la clase Coche que actualice la propiedad Año.
        public int NewYear(int newYear)
        {   
            Year = newYear;
            return Year;
        }
    }

    public class Book//● Crea una clase Libro con propiedades Titulo y Autor.
    {
        public string? Title { get; set; }
        public string? Author { get; set; }

        //● Crea una instancia de Libro, asigna valores y muestra los valores en la consola.
        public Book(string title, string author)
        {
            Title = title.ToUpper();
            Author = author;
        }
        //● Añade un método ContarPalabras(string texto) a la clase Libro que devuelva el número de palabras en un texto
        public string? CountWords(string words)
        {
            string? word = Convert.ToInt32(words.Length);
            return word;
        }
    }
}
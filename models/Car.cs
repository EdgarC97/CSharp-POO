using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO.models
{
    public class Car //● Crea una clase Coche con propiedades Marca, Modelo y Año.
    {
        public string? Brand { get; set; }
        public string? Model { get; set; }
        public int Year { get; set; }


        //● Crea una instancia de Coche, asigna valores y muestra los valores en la consola.
        public Car(string brand, string model, int year)
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
}
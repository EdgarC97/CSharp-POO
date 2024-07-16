using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO.models
{
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
        public void ShowDetails()
        {
            Console.WriteLine($"El titulo del libro es: {Title} y el autor es: {Author}");
        }
        //● Añade un método ContarPalabras(string texto) a la clase Libro que devuelva el número de palabras en un texto
        public void CountWords(string text)
        {
            string[] words = text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int numberOfWords = words.Length;
            Console.WriteLine($"El texto tiene {numberOfWords} palabras.");
        }
    }
}
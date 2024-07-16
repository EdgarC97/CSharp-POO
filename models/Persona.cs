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

    public class Product//● Crea una clase Producto con propiedades Nombre y Precio.

    {
        private string Name { get; set; }
        public decimal Price { get; set; }

        public Product(string name, decimal price)
        {
            Name = name.ToLower();
            Price = price;
        }

        public string GetName()
        {
            return Name;
        }
        public void SetName(string newName)
        {
            Name = newName.ToLower();
        }
    }

    public class BankAccount//● Crea una clase CuentaBancaria con propiedades Titular y Saldo.
    {
        public string? Holder { get; set; }
        public double Balance { get; set; }

        public BankAccount(string? holder, double balance)
        {
            Holder = holder;
            Balance = balance;
        }

        public void Deposit(double depositAmount)
        {
            Balance += depositAmount;
            Console.WriteLine($"Depósito de {depositAmount:C} realizado. Nuevo saldo: {Balance:C}");
        }

        public void WithDraw(double withdrawAmount)
        {
            Balance -= withdrawAmount;
            Console.WriteLine($"Retiro de {withdrawAmount:C} realizado. Nuevo saldo: {Balance:C}");
        }
    }

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
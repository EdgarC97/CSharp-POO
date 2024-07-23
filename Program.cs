using POO.models;

//Class Person
//● Añade un constructor a la clase Persona que acepte Nombre y Edad como parámetros.
// Person person = new Person("JOACO", 50);
// person.Greeting();
// person.ShowDetails();

// Class Car
//● Llama a este método y muestra los detalles actualizados.
// Car car = new Car("Volvo","Series II", 2020);
// car.ShowDetails();
// car.NewYear(2023);
// car.ShowDetails();

//Class Book
// class Program
// {
//     static void Main(string[] args)
//     {
//         Book book = new Book("El Príncipe", "Makiavelo");
//         book.ShowDetails();  

//         string texto = "Peperioni mussolini franquzio";
//         book.CountWords(texto);  

//     }
// }

// Class Calculator 
// class Program
// {
//     static void Main(string[] args)
//     {
//         Calculator calc = new Calculator();

//         //Sumar
//         int sumNumbers = calc.Sum(3,8);
//         Console.WriteLine($"El resultado de la suma es: {sumNumbers}");

//         //Restar
//         int restNumbers = calc.Rest(20,15);
//         Console.WriteLine($"El resultado de la resta es: {restNumbers}");
//     }
// }

//Class Product

// public class Program
// {
//     static void Main(string[] args)
//     {
//         Product product = new Product("PEPERONI", 180000);

//         Console.WriteLine($"Nombre: {product.GetName()}, Precio: {product.Price }");

//         product.SetName("CHORIZO ESpañol");

//         Console.WriteLine($"Nuevo Nombre: {product.GetName()}");
//     }
// }

//Class BankAccount
// public class Program
// {
//     static void Main(string[] args)
//     {
//         BankAccount bankAccount = new BankAccount("PEPE", 1200000);

//         Console.WriteLine($"El nombre del titular es {bankAccount.Holder} y el saldo es: {bankAccount.Balance:C}");

//         bankAccount.Deposit(200000);
//         bankAccount.WithDraw(100000);
//     }
// }

// //Class Student
// public class Program
// {
//     static void Main(string[] args)
//     {
//         Student student = new Student("JUANITO", 18, 10);

//         Console.WriteLine($"El nombre del estudiante es --> {student.Name}\nLa edad del estudiante es --> {student.GetAge()}\nEl grado del estudiante es --> {student.Grade}");

//         student.SetAge(20);
//     }
// }

//Class Rectangle
// public class Program
// {
//     static void Main(string[] args)
//     {
//         Rectangle rectangle = new Rectangle(10,5);

//         rectangle.CalculateArea();
//     }
// }

//Class Circle
// public class Program
// {
//     static void Main(string[] args)
//     {
//         Circle circle = new Circle(9);
//         circle.CalculateCircumference();
//     }
// }

//Class Employee
// public class Program
// {
//     static void Main(string[] args)
//     {
//         Employee employee = new Employee("JOACO","Arquitecto",5000000);
//         employee.ShowDetails();
//     }
// }

//Class Employee1
// public class Program
// {
//     static void Main(string[] args)
//     {
//         Employee1 employee = new Employee1("EDGAR","CARDONA","edgar@gmail.com",5000000,3,2,5);
//         employee.ShowInformation();
//         employee.ShowDeductions();
//         employee.ShowSavings();
//     }
// }

//Herencia

// class Program
// {
//     static void Main(string[] args)
//     {
//         Lyon oLyon = new Lyon();
//         oLyon.MakeSound();
//         oLyon.Name = "Pepito";

//         Buitre oBuitre = new Buitre();
//         oBuitre.Fly();
//         oBuitre.Name = "Condorito";
//     }
// }

// class Program
// {
//     static void Main(string[] args)
//     {
//         Apple redApple = new Apple("Red Apple","Red",4);
//         Apple greenApple = new Apple("Green Apple","Green",8);

//         Console.ForegroundColor = ConsoleColor.Red;
//         Console.WriteLine(redApple.DescribeMe);

//         Console.ForegroundColor = ConsoleColor.Green;
//         Console.WriteLine(greenApple.DescribeMe);
//     }
// }

// class Program
// {
//     static void Main()
//     {
//         Player player = new Player(1,"EDGAR","CARDONA","ID","123456",new DateOnly(1997, 01, 21),"O+","M","L",44,1.85,75,"Forward","Right");

//         player.ShowDetails();
//         Console.WriteLine($"IMC: {player.CalculateIMC():F2}");
//     }
// }

//STATIC
// Console.WriteLine("Hello, World!");
// Console.WriteLine(Counter.CountersTotal);
// Converter.CelsiusToFahrenheit(20);
// Configuration.ChangeMode();
// Console.WriteLine(ArithmeticCalculator.Sum(2, 2));
// HelpfulMath helpfulMath = new HelpfulMath();
// Console.WriteLine(helpfulMath.Division(8, 2));
// Storage.AddMessages("Edgar");
// Storage.ShowMessages();

//POLIMORFISMO
var doberman = new Dog("Bolt","Masculino","Canino");
doberman.MakeSound();doberman.Movement();doberman.ShowAnimalInfo();

var garfield = new Cat();
garfield.MakeSound();garfield.Movement();garfield.ShowAnimalInfo();

var nemo = new Fish();
garfield.MakeSound();nemo.Movement();nemo.ShowAnimalInfo();

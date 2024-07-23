using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO.models
{
    public class Database
{
    public static string Conection { get; set; }

    static Database()
    {
        Conection = "Ok";
    }

    public static void ShowConection()
    {
        System.Console.WriteLine("Conection " + Conection);
    }
}
}
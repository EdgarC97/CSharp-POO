using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO.models
{
    public class Configuration
{
    public static bool DarkMode = false;

    public static void ChangeMode()
    {
        DarkMode = true;
        System.Console.WriteLine(DarkMode);
    }
}
}
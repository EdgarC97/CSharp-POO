using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO.models
{
    public class Storage
    {
        public static List<string> Messages = new List<string>();
        public static void AddMessages(string userInput)
        {
            Messages.Add(userInput);
        }
        public static void ShowMessages()
        {
            foreach (var item in Messages)
            {
                Console.WriteLine(item);
            }
        }
    }
}
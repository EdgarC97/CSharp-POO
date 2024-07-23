using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO.models
{
    public class Counter
    {
        public static int CountersTotal = 2;

        public static void Increment()
        {
            CountersTotal++;
        }
    }
}
using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z2
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 100; i <= 999; i++)
            {
                if ((i % 11 == 0) && (i % 10 == 3 || i % 100 == 3 || i % 1000 == 3))
                {
                    WriteLine(i);
                }
                else continue;
            }
            ReadLine();
        }
    }
}

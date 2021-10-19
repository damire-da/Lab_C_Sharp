using System;
using static System.Console;
using static System.Math;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB2
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Введите x1 - начальное значение: ");
            double x1 = Convert.ToDouble(ReadLine());
            WriteLine("Введите x2 - конечное значение: ");
            double x2 = Convert.ToDouble(ReadLine());
            WriteLine("Введите шаг dx: ");
            double dx = Convert.ToDouble(ReadLine());
            WriteLine("{0,10}  {1,10}  {2,10}  {3,10}", "k", "F(x)", "x", "dx");

            FindY(x1, x2, dx);
            ReadLine();
        }
        static void FindY(double x1, double x2, double dx)
        {
            double fx, x;
            x = x1;
            int count = 0;
            while (x <= x2)
            {
                
                count++;
                if (-7 <= x && x <= -3) fx = x + 7;
                else if (x > -3 && x < -2) fx = 4;
                else if (x >= -2 && x <= 2) fx = x * x;
                else if (x > 2 && x <= 4) fx = -2 * x + 8;
                else break;
                WriteLine("{0,10} | {1,10} | {2,10} | {3,10}",count, fx, x, dx);
                x += dx;
            }
        }
    }
}

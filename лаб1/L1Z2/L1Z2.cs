using System;
using static System.Math;

namespace L1Z2
{
    class L1Z2
    {
        static void Main(string[] args)
        {
            double a, b, x, y;
            double PI = 3.14;
            double e = 2.718;
            Console.WriteLine("Введите значение а: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение b: ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение x: ");
            x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("С помощью тернарного оператора");
            Tern(a, b, x, e, PI);
            Console.WriteLine("С помощью простого условия");
            Condition(a ,b, x, e, PI);
            Console.ReadLine();
        }
        static void Tern(double a, double b, double x, double e, double PI)
        {

            double y1 = b * Pow(e, -3 * x) + Pow(Sin(a * PI / 360), 2);
            double y2 = Pow(x, 3) / a - x / b;
            double y = (a * b < 2 * x) ? y1 : y2;
            Console.WriteLine("Значение функциин y = " + Round(y, 3));
            
        }
        static void Condition(double a, double b, double x, double e, double PI)
        {
            double y;
       
            if (a * b < 2 * x)
            {
                y = b * Pow(e, -3 * x) + Pow(Sin(a * PI / 360), 2);
            }
            else
            {
                y = Pow(x, 3) / a - x / b;
            }
            Console.WriteLine("Значение функциин y = " + Round(y, 3));
            
        }
    }
}

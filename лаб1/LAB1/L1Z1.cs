using System;
using static System.Math;

namespace LAB1
{
    class L1Z1
    {
        static void Main(string[] args)
        {
            try
            {
                double PI = 3.14;
                double x, y;//параметры функции
                x = Convert.ToDouble(Console.ReadLine());//преобразование из string в double
                y = Convert.ToDouble(Console.ReadLine());//преобразование из string в double
                double Z1 = Pow(Cos(x * PI / 360), 4) + Pow(Sin(y * PI / 360), 2) + 1.0 / 4 * Pow(Sin(2 * x * PI / 360), 2) - 1;// функция
                double Z2 = Sin((y + x) * PI / 360) * Sin((y - x) * PI / 360);// функция
                Console.WriteLine("Значение Z1 = " + Round(Z1, 3));
                Console.WriteLine("Значение Z2 = " + Round(Z1, 3));
                Console.ReadLine();
            }
            catch
            {
                Console.WriteLine(" Неверный ввод данных!");
            }
        }
    }
}

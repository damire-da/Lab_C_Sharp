using System;
using static System.Math;
using static System.Console;

namespace LAB3
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            int n = 10;
            

            WriteLine("Введите значение C: ");
            float C = Convert.ToSingle(ReadLine());
            float lastNum;
            int lastNumI = 0;
            float sum = 0;
            Random rnd = new Random();
            float[] numbers = new float[n];
            for(int i = 0; i < n; i++)
            {
                float z1 = rnd.Next(-100, 100);
                numbers[i] = z1 / 10;
                if (numbers[i] < 0)
                {
                    lastNum = numbers[i];
                    lastNumI = i;
                }
            }
            WriteLine("Массив: ");
            for(int i = 0; i < n; i++)
            {
                if (numbers[i] < C) count++;
                if (i > lastNumI) sum += numbers[i];
                WriteLine(numbers[i]);
            }
            WriteLine($"Сумма элементов, расположенных после последнего отрицательного элемента: {sum}");
            WriteLine($"Количество элементов, которые меньше С: {count}");


            ReadLine();
        }
    }
}

using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L4
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int a = 10;
            List<int> numbers = new List<int>(5);

            //Заполнение
            WriteLine("Первый список:");
            for (int i = 0; i < numbers.Capacity; i++)
            {
                numbers.Add(rnd.Next(-30,6));
                WriteLine(numbers[i]);
            }
            WriteLine();

            WriteLine("Добавили элемент в 1 список:");
            numbers.Add(a);
            foreach (int number in numbers)
            {
                WriteLine(number);
            }
            WriteLine();

            List<int> numberss = new List<int>(3);

            WriteLine("Второй список:");
            //Заполнение
            for (int i = 0; i < numberss.Capacity; i++)
            {
                numberss.Add(rnd.Next(-30, 6));
                WriteLine(numberss[i]);
            }
            numbers.InsertRange(2,numberss);
            WriteLine();
            //добавление 2-го списка к 1
            WriteLine("Объединили 1 и 2 списки:");
            WriteLine(string.Join(" ", numbers));
            WriteLine();

            //кол-во элементов в 1-ом списке
            
            WriteLine("Кол-во элементов в списке:");
            WriteLine(numbers.Count);
            WriteLine();

            WriteLine("Максимальный элемент списка:");
            WriteLine(numbers.Max());
            WriteLine();

            WriteLine("Минимальный элемент списка:");
            WriteLine(numbers.Min());
            WriteLine();

            int[] arr = numberss.ToArray();
            WriteLine("Массив из 2-го списка:");
            WriteLine(string.Join(" ", arr));
            WriteLine();

            numberss.RemoveAt(1);
            WriteLine("Удалили второй элемент второго списка:");
            WriteLine(string.Join(" ", numberss));

        }
    }
}

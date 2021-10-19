using System;
using static System.Math;
using static System.Console;

namespace z2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, m;
            int sum = 0;
            int template;
            WriteLine("Введите размер матрицы N x M: ");
            n = Convert.ToInt32(ReadLine());
            m = Convert.ToInt32(ReadLine());
            Random rnd = new Random();
            int[,] matrix = new int[n, m];
            int count = 0;

            for (int i = 0; i < n; i++)
            {
                count = 0;
                for (int j = 0; j < m; j++)
                {
                    //Заполнение массива
                    matrix[i, j] = rnd.Next(-20, 20);
                    if (matrix[i, j] > 0) count++;
                    Write($"{matrix[i, j]} ");
                }
                if (count == m)
                {
                    for (int j = 0; j < m; j++)
                    {
                        sum += matrix[i, j];
                    }
                }
                WriteLine();
            }


            WriteLine($"Сумма: {sum}");
            WriteLine("Изменённая матрицы: ");
            for (int j = 0; j < m; j++)
            {
                template = matrix[n - 1, j];
                matrix[n - 1, j] = matrix[n - 2 , j];
                matrix[n - 2, j] = template;
            }
            WriteLine();

            for (int i = 0; i < n; i++)
            {
                count = 0;
                for (int j = 0; j < m; j++)
                {
                    Write($"{matrix[i, j]} ");
                }
                WriteLine();
            }

        }
    }
}

using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z23
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[][] numbers = new int[5][];
            numbers[0] = new int[5];
            numbers[1] = new int[3];
            numbers[2] = new int[8];
            numbers[3] = new int[4];
            numbers[4] = new int[6];
            int[] sum = new int[numbers.Length];
            for (int i = 0; i < numbers.Length; i++) 
            {
                for (int j = 0; j < numbers[i].Length; j++)
                {
                    numbers[i][j] = rnd.Next(-500, 500);
                    Write($"{numbers[i][j],8} ");
                    sum[i] += numbers[i][j]; 
                }

                WriteLine();
            }
            for (int i = 0; i < sum.Length; i++)
            {
                WriteLine($" Сумма {i}-го массива: {sum[i]}");
            }
        }
    }
}

using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L5
{
    class Program
    {
        static void Main(string[] args)
        {
            Write("Введите строку: ");
            string s1 = ReadLine();
            string s2 = "";
            string s3 = "";
            for (int i = s1.Length - 1; i >= 0; i--)
            {
                s2 = String.Concat(s2,s1[i]);
            }
            Write("Перевернутая строка: ");
            WriteLine(s2);
            string[] words = s1.Split(new char[] { ' ', ',', '.' }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = words.Length - 1; i >= 0; i--)
            {
                s3 = String.Concat(s3, words[i]);
                s3 += " ";
            }
            Write("Зеркальная строка: ");
            WriteLine(s3);
        }
    }
}

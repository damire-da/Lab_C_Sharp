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
            string s1 = "Lorem Ipsum is simplybook, fefefe rwerwrw.";
            string[] words = s1.Split(new char[] { ' ', ',' , '.' }, StringSplitOptions.RemoveEmptyEntries);
            int k = words[0].Length;
            string wordd = " ";
            foreach (string word in words)
            {
                if (k < word.Length)
                {
                    k = word.Length;
                    wordd = word;
                }
            }
            WriteLine($"Самое длинное слово: {wordd} Его длина: {k}");
            
        }
    }
}

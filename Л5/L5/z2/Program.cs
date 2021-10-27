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
            char[] sym = s1.ToCharArray();
            for (int i = 0; i < sym.Length; i++)
            {
                int tem = Convert.ToInt32(sym[i]);
                if(tem > 96 && tem < 123)
                {
                    tem += k;
                    if (tem > 123)
                    {
                        tem = tem % 122 + 96;
                    }
                    sym[i] = Convert.ToChar(tem);
                }
                else if(tem > 65 && tem < 91)
                {
                    tem += k;
                    if (tem > 90)
                    {
                        tem = tem % 90 + 64;
                    }
                    sym[i] = Convert.ToChar(tem);
                }
            }
            for (int i = 0; i < sym.Length; i++)
            {
                Write($"{sym[i]}");
            }
            WriteLine($"\nK = {k}");
            
        }
    }
}

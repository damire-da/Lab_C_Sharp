using System;
using System.IO;
using System.Threading.Tasks;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z1
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "eext.txt";
            List<string> lines = new List<string>();
            int max = 0;
            int k = 0;
            string maxWord = " ";
            using (StreamReader f = new StreamReader(path))
            {
                while (!f.EndOfStream)
                {
                    lines.Add(f.ReadLine());
                }
                for (int i = 0; i < lines.Count; i++)
                {
                    string[] line = lines[i].Split(' ', '.', ',', '!', '?');
                    for(int j = 0; j < line.Length; j++)
                    {
                        if (max < line[j].Length)
                        {
                            max = line[j].Length;
                            maxWord = line[j];
                        }
                    }
                }
                for (int i = 0; i < lines.Count; i++)
                {
                    string[] line = lines[i].Split(' ', '.', ',', '!', '?');
                    for (int j = 0; j < line.Length; j++)
                    {
                        if (maxWord == line[j]) k++;
                    }
                }


                WriteLine($"Самое длинное слово: {maxWord} встречается в тексте: {k} раз/а, его длина: {max}");
                f.Close();
            }
            
        }
    }
}

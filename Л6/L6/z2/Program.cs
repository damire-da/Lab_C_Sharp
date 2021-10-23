using System;
using System.IO;
using System.Threading.Tasks;
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
            string path = "club.txt";
            string path_2 = "club_2.txt";
            string[] types = new string[10];
            List<string> club = new List<string>();
            try
            {
                StreamReader fr = new StreamReader(path);
                StreamWriter fw = new StreamWriter(path_2, true);
                while (!fr.EndOfStream)
                {
                    club.Add(fr.ReadLine());
                }
                for (int i = 0; i < club.Count; i++)
                {
                    string[] clubs = club[i].Split(' ');
                    types[i] = clubs[1];// сохраняем виды спорта в отдельный массив
                }
                var type = types.Distinct().ToArray();//удаляем все повторения видов спорта
                for (int i = 0; i < 3; i++)
                {
                    fw.Write($"{type[i]}:\n");
                    for (int j = 0; j < club.Count; j++)
                    {
                        string[] clubs = club[j].Split(' ');
                        if (clubs[1] == type[i])
                        {
                            fw.Write($"{clubs[0],10} {clubs[2],10}\n");
                        }
                    }
                }
                WriteLine("В файл записаны данные");
                fr.Close();
                fw.Close();
            }
            catch (Exception e)
            {

                WriteLine(e.Message);
            }
        }
    }
}

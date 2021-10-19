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
            
            List<string> club = new List<string>();
            StreamReader fr = new StreamReader(path);
            StreamWriter fw = new StreamWriter(path_2);
            while (!fr.EndOfStream)
            {
                club.Add(fr.ReadLine());
            }
            string[] type = new string[5];
            string[] team = new string[10];
            for (int i = 0; i < club.Count; i++)
            {
                string[] teams = club[i].Split(' ', '.', ',', '!', '?');
                type[i] = team[0];//массив видов спорta
            }
            for (int i = 0; i < type.Length; i++)
            {
                var clubGroups = from u in type
                                 group u by type[i];
                WriteLine(type[i]);
                foreach(IGrouping<string, string> g in clubGroups)
                {
                    WriteLine(g.ElementAt(1));
                }
            }


            fr.Close();
        }
    }
}

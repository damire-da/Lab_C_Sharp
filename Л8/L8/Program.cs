using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L8
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int[] elements = new int[] { 1, 2, 3, 48, 44, 5, 6 ,14,10,33};
            int[] elements2 = new int[] { 1, 2, 12,44, 4, 5, 6,7,10, };
            Set set1 = new Set(elements);
           
            //set1.ShowSet();
            //Console.WriteLine(set1.IndexOf(10));
            //set1.Add(20);
            //set1.ShowSet();
            //индексатор работает
            //Console.WriteLine(set1[4]);
            // операции
            Set set2 = new Set(elements2);
            set1.ShowSet();
            //set2.ShowSet();

            set1 = set1++;
            set1.ShowSet();
            //Set set3 = set1 * set2;
            //set3.ShowSet();


        }
    }

}

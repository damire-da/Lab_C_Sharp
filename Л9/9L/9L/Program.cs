using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9L
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();
            Person p2 = new Person();
            bool res = p1 != p2;
            Console.WriteLine(res);
            //Console.WriteLine(p1.Equals(p2));
        }
    }
}

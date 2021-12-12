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
            //Person p1 = new Person();
            //Person p2 = new Person();
            //bool res = p1 != p2;
            //Console.WriteLine(res);
            //Console.WriteLine(p1.Equals(p2));
            Student st1 = new Student();
            
            
            
            st1.AddTest(new Test());
            st1.AddExam(new Exam());
            //
            Student st2 = st1.DeepCopy() is Student st ? st : null;
            Console.WriteLine(st1.ToString());
            Console.WriteLine(st2.ToString());

            st1.FirstName = "rr";
            Console.WriteLine(st1.ToString());
            Console.WriteLine(st2.ToString());

            Person p = new Person();
            Person p2 = new Person();
            Console.WriteLine(p.GetHashCode());
            Console.WriteLine(p2.GetHashCode());
            bool res = p == p2;
            Console.WriteLine(res);
            p2.FirstName = "jj";
            Console.WriteLine(p.GetHashCode());
            Console.WriteLine(p2.GetHashCode());
            Console.WriteLine(p.Equals(p2));
            

            st1.AddExam(new Exam("CS", 3, new DateTime(21, 12, 25)));

            //Console.WriteLine(st1.ToString());
            //Console.WriteLine("SS");
            // Console.WriteLine(st1.Person);
            try
            {
                st1.Group = 600;
                Console.WriteLine(st1.Group);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);

            }
            
            foreach (object item in st1)
            {
                Console.WriteLine(item);
            }
            foreach (Exam item in st1.GetEnumerable(3))
            {
                Console.WriteLine(item);
            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L10
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Задание №1");
            Student st1 = new Student(new Person("Bill", "Bowson", new DateTime(2003,5,2)),
                Education.Specialist, 121);
            st1.AddExam(new Exam("Math",5,new DateTime(21,12,14)));
            
            st1.AddTest(new Test());
            Student st2 = new Student(new Person("A","Aeg",new DateTime(2002,2,2)),
                Education.SecondEducation,333);
            st2.AddExam(new Exam("Cs", 4,new DateTime(21,12,13)));
            Student st4 = new Student()
            {
                Person = new Person("Ruri", "Cik", new DateTime(1999, 3, 2))
            };
            st4.AddExam(new Exam("History",3,new DateTime(21,11,15)));

            Student st3 = new Student();
            st3.AddExam(new Exam("Biology",5,new DateTime(21,11,15)));
            st3.FirstName = "Ray";
            StudentCollection col = new StudentCollection();
            
            col.AddStudent(st1);
            col.AddStudent(st2);
            col.AddStudent(st3);
            col.AddStudent(st4);
            Console.WriteLine(col.ToString());
            Console.WriteLine("!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!" + 
                              "!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
            Console.WriteLine("Задание №2"); 
            Console.WriteLine(col.ToShortString());
            Console.WriteLine("Сортировка по фамилии:");
            col.LastNameSort();
            Console.WriteLine(col.ToShortString());
            Console.WriteLine("Сортировка по Дате рождения:");
            col.DateSort();
            Console.WriteLine(col.ToShortString());
            Console.WriteLine("Сортировка по среднему баллу:");
            col.AvgSort();
            Console.WriteLine(col.ToShortString());
            Console.WriteLine("!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!" + 
                              "!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
            Console.WriteLine("Задание №3");
            int g = 5;
            Console.WriteLine($"Группировка по оценке {g}:");
            List<Student> st = col.AverageMarkGroup(g);
            foreach (var s in st)
            { 
                Console.WriteLine(s.ToShortString());
            }
            
            Console.WriteLine("\nСтуденты специалитета:");
            foreach (var s in col.TypeEducation)
            { 
                Console.WriteLine(s.ToShortString());
            }
            Console.WriteLine("\nМаксимальная оценка среди студентов:");
            Console.WriteLine($"{col.MaxAvg}");

            Console.WriteLine("!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!" + 
                              "!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
            Console.WriteLine("Задание №4");
            int c;
            do
            {
                try
                {
                    Console.WriteLine("Введите количество элементов в коллекции:");
                    c = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Неверный формат ввода. Введите число действительного типа");
                }
            } while (true);

            TestCollections test = new TestCollections(c);
            test.SearchElement(1);
            if (c % 2 == 0)
                test.SearchElement(c / 2);
            else if (c % 2 != 0)
                test.SearchElement(c / 2 + 1 );
            test.SearchElement(c);
            test.SearchElement(10);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L7
{
    class Program
    {
        enum Education
        {
            Specialist,
            Bachelor,
            SecondEducation
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Создание студента_1");
            // Обычная инициализация
            Student student_1 = new Student(new Person("Aaron", "Lewis", new DateTime(2000,12,20)),L7.Education.Specialist,1232);
            student_1.Exam = new Exam[]
            {
                new Exam("History",4,new DateTime(2021, 1, 10)),
                new Exam("Geography", 3, new DateTime(2021, 1, 7))
            };
            // Инициализация обьектов класса
            Console.WriteLine("Создание студента_0");
            Student student_0 = new Student()
            {
                Person = new Person
                {
                    FirstName = "Rere",
                    LastName = "Gug",
                    Birthday = new DateTime(2000, 11, 17)
                },
                Group = 121231,

                Exam = new Exam[]
                {
                    new Exam
                    {
                        Subject = "Computer Science",
                        
                        DateExam = new DateTime(2021, 1, 15),
                    },
                    new Exam
                    {
                        Subject = "Mathematics",
                        Grade = 5,
                        DateExam = new DateTime(2021, 1, 15),
                    }
                }
            };



            Console.WriteLine("Данные студента_0(метод ToShortString)");
            Console.WriteLine(student_0.ToShortString());
            Console.WriteLine("Данные студента_0(метод ToString)");
            Console.WriteLine(student_0.ToString());


            Console.WriteLine("Данные студента_1(метод ToString)");
            Console.WriteLine(student_1.ToString());
            // значения индексатора
            Console.WriteLine("Проверка образования студента студента_0(индексатор)");
            Console.WriteLine(student_0[L7.Education.SecondEducation]);
            Console.WriteLine(student_0[L7.Education.Bachelor]);
            Console.WriteLine(student_0[L7.Education.Specialist]);

            // добавление экзамена
            Console.WriteLine("Добавление экзаменов студенту_0");
            student_0.AddExam(new Exam("Duetch", 5, new DateTime(2021, 1, 20)), new Exam("Probability Theory", 4, new DateTime(2021,1,18)),
                new Exam("C#",5, new DateTime(2021, 1, 22)));
            Console.WriteLine(student_0.ToString());
            
        }
    }
}
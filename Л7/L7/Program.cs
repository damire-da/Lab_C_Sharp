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
            Student student = new Student();
            Exam cs = new Exam("CS", 4, new DateTime(2021, 1, 15));
            Exam mathematics = new Exam();
            Exam[] exams = { cs, mathematics };
            student.Exam = exams;
            Console.WriteLine(student.ToShortString());
            student.AddExam(new Exam("DB", 3, new DateTime(2021,6,14)), new Exam("Access", 5, new DateTime(2021,4,12)));
            Console.WriteLine(student.ToString());



        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9L
{
    class Exam : IDateAndCopy
    {
        // constructors
        public Exam(string subject, int grade, DateTime date_exam)
        {
            Subject = subject;
            Grade = grade;
            Date = date_exam;
        }
        public Exam()
        {
            Subject = "Mathematics";
            Grade = 5;
            Date = new DateTime(2021,1,17);

        }

        // properties
        public string Subject { get; set; }
        public int Grade { get; set; }
        //public DateTime DateExam { get; set; }
        public DateTime Date { get; set; }


        // methods
        public override string ToString()
        {
            return Subject + " " + Grade + " " + Date.ToShortDateString();
        }

        public object DeepCopy()
        {
            return new Exam
            {
                Subject = Subject,
                Grade = Grade,
                Date = Date
            };
        }
    }
}

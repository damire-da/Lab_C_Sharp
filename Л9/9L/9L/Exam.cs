using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9L
{
    class Exam
    {
        // constructors
        public Exam(string subject, int grade, DateTime date_exam)
        {
            Subject = subject;
            Grade = grade;
            DateExam = date_exam;
        }
        public Exam()
        {
            Subject = "Mathematics";
            Grade = 5;
            DateExam = new DateTime(2021,1,17);
        }

        // properties
        public string Subject { get; set; }
        public int Grade { get; set; }
        public DateTime DateExam { get; set; }

        // methods
        public override string ToString()
        {
            return Subject + " " + Grade + " " + DateExam.ToShortDateString();
        }
    }
}

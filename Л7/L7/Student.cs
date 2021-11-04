using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L7
{
    enum Education
    {
        Specialist,
        Bachelor,
        SecondEducation
    }
    class Student
    {
        // constructors
        public Student(Person person, Education education, int group)
        {
            this.person = person;
            this.education = education;
            this.group = group;
        }

        public Student()
        {
            person = new Person();
            education = Education.Bachelor;
            group = 190222;
        }
        // properties
        private Person person;
        public Person Person
        {
            get { return person; }
            set { person = value; }
        }

        private Education education;
        public Education Education
        {
            get { return education; }
            set { education = value; }
        }

        private int group; // №группы
        public int Group
        {
            get { return group; }
            set { group = value; }
        }
        
        private Exam[] exam;
        public Exam[] Exam
        {
            get { return exam; }
            set { exam = value; }
        }

        private double average_grade;

        public double AverageGrade
        {
            get 
            {
                for (int i = 0; i < Exam.Length; i++)
                {
                    average_grade += Exam[i].Grade;
                }
                return average_grade/Exam.Length;
            }
        }
        
        public bool this[Education education]
        {
            get 
            {
                if (this.education == education) return true;
                else return false;
            }
        }


        //methods
        public void AddExam(params Exam[] exam)
        {
            Exam[] newArray = new Exam[this.exam.Length + exam.Length];

             
            for (int i = 0; i < this.exam.Length; i++)
            {
                newArray[i] = this.exam[i];
            }
            int j = this.exam.Length;
            for (int i = 0; i < exam.Length; i++)
            {
                newArray[j] = exam[i];
                j++;
            }
            Exam = newArray;
        }

        public override string ToString()
        {
            string s = $"{person.ToString()} {group} {education}";
            for (int i = 0; i < exam.Length; i++)
            {
                s += $" {exam[i]}";
            }
            return s;
        }

        public virtual string ToShortString()
        {
            return $"{person.ToString()} {group} {education} {AverageGrade}";
        }
    }
}

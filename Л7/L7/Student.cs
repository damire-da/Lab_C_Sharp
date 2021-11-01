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
        
        private Exam[] exams;
        public Exam[] Exam
        {
            get { return exams; }
            set { exams = value; }
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
        // как сделать?
        public void AddExam(params Exam[] exam)
        {
            Exam[] newArray = new Exam[exams.Length + 1];

            newArray[exams.Length+1] = exam[0]; 
            for (int i = 0; i < exam.Length+1; i++)
            {
                newArray[i] = exam[i];
            }
        }

        public override string ToString()
        {
            string s = $"{person.ToString()} {group} {education}";
            for (int i = 0; i < exams.Length; i++)
            {
                s += $" {exams[i]}";
            }
            return s;
        }

        public virtual string ToShortString()
        {
            return $"{person.ToString()} {group} {education} {AverageGrade}";
        }
    }
}

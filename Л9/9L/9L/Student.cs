using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9L
{
    enum Education
    {
        Specialist,
        Bachelor,
        SecondEducation
    }
    class Student : Person, IDateAndCopy
    {
        #region constructors
        public Student(Person person, Education education, int group) : base(person.FirstName, person.LastName, person.Date)
        {
            Education = education;
            Group = group;
        }

        public Student() : base()
        {
            education = Education.Bachelor;
            group = 222;

        }
        #endregion

        #region properties
        private Person person = new Person();

        public Person Person
        {
            get
            {
                return person;
            }
            set
            {
                
                person.FirstName = FirstName;
                person.LastName = LastName;
                person.Date = Date;
            }
        }

        private ArrayList test = new ArrayList();

        public ArrayList Test
        {
            get { return test; }
            set { test.Add(value); }
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
            set
            {
                if (value > 100 && value < 599)
                    group = value;
                else
                    throw new Exception("Присвоены недопустимые значения\n" +
                        "(Допустимые значения 100 < номер группы < 599)");
            }
        }
        private ArrayList exam = new ArrayList();
        public ArrayList Exam
        {
            get { return exam; }
            set { exam.Add(value); }
        }

        private double average_grade;

        public double AverageGrade
        {
            get 
            {
                average_grade = 0;
                for (int i = 0; i < exam.Count; i++)
                {
                    if(exam[i] is Exam ex)
                    {
                        average_grade += ex.Grade;
                    }
                }
                return average_grade/exam.Count;
            }
        }
        #endregion

        #region indexer
        public bool this[Education education]
        {
            get 
            {
                return this.education == education;
            }
        }
        #endregion

        #region methods

        
        public void AddExam(params Exam[] exam)
        {
            //Exam[] newArray = new Exam[Exam.Count + exam.Length];
            ArrayList newArray = new ArrayList(new Exam[exam.Length]);

            for (int i = 0; i < exam.Length; i++)
            {
                if (exam[i] is Exam ex)
                    newArray[i] = ex;
            }
            
            Exam.AddRange(newArray);
        }

        public void AddTest(params Test[] test)
        {
            //Exam[] newArray = new Exam[Exam.Count + exam.Length];
            ArrayList newArray = new ArrayList(new Test[test.Length]);

            for (int i = 0; i < test.Length; i++)
            {
                if (test[i] is Test tes)
                    newArray[i] = tes;
            }

            Test.AddRange(newArray);
        }

        public override string ToString()
        {
            string s = $"{base.ToString()} {group} {education}\n";
            s += "Список экзаменов:";
            foreach (var exam in Exam)
            {
                if (exam is Exam ex)
                    s += exam.ToString();
            }

            
            s+= "\nСписок зачётов:";
            foreach (var test in Test)
            {
                if(test is Test tes)
                    s += test.ToString();
            }
            return s;
        }

        public virtual string ToShortString()
        {
            return $"{base.ToString()} {group} {education} {AverageGrade}";
        }

        public override object DeepCopy()
        {
            return new Student
            {
                LastName = LastName,
                FirstName = FirstName,
                Date = Date,
                Education = Education,
                Group = Group,
                exam = exam,
                test = test, 
            };
        }

        public IEnumerator GetEnumerator()
        {
            foreach (object item in Exam)
            {
                yield return item;
            }
            foreach (object item in Test)
            {
                yield return item;
            }
        }
        public IEnumerable GetEnumerable(int g)
        {
            foreach (Exam item in Exam)
            {
                if (item.Grade > g)
                    yield return item;
                else
                    yield break;
            }
        }
        #endregion
    }
}




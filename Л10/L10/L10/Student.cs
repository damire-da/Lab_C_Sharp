using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using L10;

namespace L10
{
    public enum Education
    {
        Specialist,
        Bachelor,
        SecondEducation
    }
    public class Student : Person, IDateAndCopy
    {
        #region constructors
        public Student(Person person, Education education, int group) : base()
        {
            FirstName = person.FirstName;
            LastName = person.LastName;
            Date = person.Date;
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

        

        public Person Person
        {
            get
            {
                return new Person(FirstName, LastName, Date);
            }
            set
            {
                FirstName = value.FirstName;
                LastName = value.LastName;
                Date = value.Date;
            }
        }

        private List<Test> test = new List<Test>();

        public List<Test> Test
        {
            get { return test; }
            set { test = value; }
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
        private List<Exam> exam = new List<Exam>();
        public List<Exam> Exam
        {
            get { return exam; }
            set { exam = value; }
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

                try
                {
                    return average_grade/exam.Count;
                }
                catch (Exception e)
                {
                    throw new Exception(e.Message);
                }
                
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
            for (int i = 0; i < exam.Length; i++)
            {
                Exam.Add(exam[i]);
            }
        }

        public void AddTest(params Test[] test)
        {
            for (int i = 0; i < test.Length; i++)
            {
                Test.Add(test[i]);
            }
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

        public override string ToShortString()
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
        
        public override int CompareTo(object obj)
        {
            if (obj is Student s)
                return LastName.CompareTo(s.LastName);
            
            throw new AggregateException("Object is not a Person");
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

    public class StudentAvg : IComparer<Student>
    {
        public int Compare(Student st1, Student st2)
        {
            if (st1.AverageGrade > st2.AverageGrade) return -1;
            if (st1.AverageGrade < st2.AverageGrade) return 1;
            return 0;
        }
    }
}




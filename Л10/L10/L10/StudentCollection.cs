using System;
using System.Collections.Generic;
using System.Linq;

namespace L10
{
    public class StudentCollection
    {
        private List<Student> _students = new List<Student>();

        public double MaxAvg
        {
            get { return _students is null ? 3 : _students.Max(g => g.AverageGrade); }
        }

        public IEnumerable<Student> TypeEducation
        {
            get
            {
                return _students.Where(e => e.Education == Education.Specialist);
            }
        }

        public List<Student> AverageMarkGroup(double value)
        {
            try
            {
                return
                    _students
                        .GroupBy(student => student.AverageGrade, (avg, students) => (Avg: avg, StudentGroup: students))
                        .FirstOrDefault(group => group.Avg == value)
                        .StudentGroup.ToList();
            }
            catch { return null; }
        }
        public void AddDefaults()
        {
            List <Student> students = new List<Student>() {new Student(), new Student()};
            _students.AddRange(students);
        }
        
        public void AddStudent(params Student[] students)
        {
            foreach (var s in students)
            {
                _students.Add(s);
            }
        }

        public override string ToString()
        {
            string s = "";
            foreach (var student in _students)
            {
                s += $"\n{student.ToString()}";
            }
            return s;
        }
        public virtual string ToShortString()
        {
            string s = "";
            foreach (var student in _students)
            {
                s += $"{student.ToShortString()}";
                
                s += $"\n\tКол-во экзаменов {student.Exam.Count}";
                s += $"\n\tКол-во тестов {student.Test.Count}\n";
            }
            return s;
        }

        public void LastNameSort()
        {
            _students.Sort((st1,st2) => st1.LastName.CompareTo(st2.LastName));
        }

        public void DateSort()
        {
            _students.Sort(new Person());
        }

        public void AvgSort()
        {
            _students.Sort(new StudentAvg());
        }
    }
}
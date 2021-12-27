using System;
using System.Collections;
using System.Collections.Generic;

namespace L10
{
    class Auxiliary : IComparer<Student>
    {
        public int Compare(Student st1, Student st2)
        {
            if (st1.AverageGrade > st2.AverageGrade) return 1;
            if (st1.AverageGrade < st2.AverageGrade) return -1;
            
            return 0;
        }
    }
}
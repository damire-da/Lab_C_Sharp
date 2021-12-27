using System;
using System.Collections.Generic;
using System.Linq;

namespace L10
{
    public class TestCollections
    {
        private List<Person> _persons = new List<Person>();
        private List<string> _list = new List<string>();
        private Dictionary<Person, Student> _dict = new Dictionary<Person, Student>();
        private Dictionary<string, Student> _students = new Dictionary<string, Student>();

        public TestCollections(int size)
        {
            for (int i = 1; i < size + 1; i++)
            {
                Student st = LinkStudent(i);
                _persons.Add(st.Person);
                _list.Add(st.Person.ToString());
                _dict.Add(st.Person, st);
                _students.Add(st.Person.ToString(),st);
            }
        }
        
        private static Student LinkStudent(int val)
        {
            return new Student(
                person: new Person(
                    val.ToString(),val.ToString(),new DateTime(val)),
                education: Education.Bachelor,
                group: 220);
        }

        public void SearchElement(int val)
        {
            Student st = LinkStudent(val);
            
            if (_dict.ContainsValue(st))
            {
                int StartOfOperation = Environment.TickCount;
                if (_persons.Contains(st.Person))
                {
                    int FinalOperation = Environment.TickCount - StartOfOperation;
                    Console.WriteLine($"В List<Person> элемент №{val} найден за {FinalOperation}ms");
                }
            
                int StartOfOperation1 = Environment.TickCount;
                if (_list.Contains(st.Person.ToString()))
                {
                    int FinalOperation = Environment.TickCount - StartOfOperation1;
                    Console.WriteLine($"В List<string> элемент №{val} найден за {FinalOperation}ms");
                }
            
                int StartOfOperation2 = Environment.TickCount;
                if (_dict.ContainsKey(st.Person))
                {
                    int FinalOperation = Environment.TickCount - StartOfOperation2;
                    Console.WriteLine($"В List<Person, Student> элемент №{val} по ключу найден за {FinalOperation}ms");
                }
            
                int StartOfOperation3 = Environment.TickCount;
                if (_dict.ContainsValue(st))
                {
                    int FinalOperation = Environment.TickCount - StartOfOperation3;
                    Console.WriteLine($"В List<Person, Student> элемент №{val} по значению найден за {FinalOperation}ms");
                }
            
                int StartOfOperation4 = Environment.TickCount;
                if (_students.ContainsKey(st.Person.ToString()))
                {
                    int FinalOperation = Environment.TickCount - StartOfOperation4;
                    Console.WriteLine($"В List<Person, Student> элемент №{val} по значению найден за {FinalOperation}ms");
                }
            }
            else
            {
                int StartOfOperation = Environment.TickCount;
                int FinalOperation = Environment.TickCount - StartOfOperation;
                Console.WriteLine($"Элемент не находящийся в коллекции найден за {FinalOperation}ms");
            }
        }
    }
}
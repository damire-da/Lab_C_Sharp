using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L7
{
    class Person
    {
        // Constructors
        public Person(string first_name, string last_name, DateTime birthday)
        {
            _first_name = first_name;
            _last_name = last_name;
            _birthday = birthday;
        }

        public Person()
        {
            _first_name = "Jacob";
            _last_name = "Kelly";
            _birthday = new DateTime(2000,10,5);
        }

        // Properties
        private string _first_name;

        public string FirstName
        {
            get { return _first_name; }
            set { _first_name = value; }
        }

        private string _last_name;

        public string LastName
        {
            get { return _last_name; }
            set { _last_name = value; }
        }

        private DateTime _birthday;

        public DateTime MyProperty
        {
            get { return _birthday; }
            set { _birthday = value; }
        }

        // Methods
        public override string ToString()
        {
            string data = $"{_first_name} {_last_name} {_birthday.ToShortDateString()}";
            return data;
        }

        public virtual string ToShortString()
        {
            string data = $"{_first_name} {_last_name}";
            return data;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9L
{
    class Person : IDateAndCopy
    {
        #region constructors
        public Person(string first_name, string last_name, DateTime birthday)
        {
            _first_name = first_name;
            _last_name = last_name;
            Date = birthday;
        }

        public Person()
        {
            _first_name = "Jacob";
            _last_name = "Kelly";
            Date = new DateTime(2000,10,5);
        }
        #endregion

        #region properties
        protected string _first_name;

        public string FirstName
        {
            get { return _first_name; }
            set { _first_name = value; }
        }

        protected string _last_name;

        public string LastName
        {
            get { return _last_name; }
            set { _last_name = value; }
        }

        public DateTime Date { get; set; }

        #endregion

        #region methods
        public override string ToString()
        {
            string data = $"{_first_name} {_last_name} {Date.ToShortDateString()}";
            return data;
        }

        public virtual string ToShortString()
        {
            string data = $"{_first_name} {_last_name}";
            return data;
        }

        public virtual object DeepCopy()
        {
            return new Person
            {
                FirstName = FirstName, 
                LastName = LastName,
                Date = Date,
            };
        }

        public override bool Equals(object obj)
        {
            if (obj is Person person)
            {
                return person.FirstName == FirstName &&
                       person.LastName == LastName &&
                       person.Date == Date;
            }

            return false;
        }

        public override int GetHashCode()
        {
            int hashcode = _first_name.GetHashCode() + _last_name.GetHashCode() + Date.GetHashCode();
            return hashcode;
        }
        #endregion

        #region operator
        public static bool operator ==(Person p1, Person p2)
        {
            return p1.FirstName == p2.FirstName && 
                   p1.LastName == p2.LastName &&
                   p1.Date == p2.Date;
        }
        public static bool operator !=(Person p1, Person p2)
        {
            return p1.FirstName != p2.FirstName ||
                   p1.LastName != p2.LastName ||
                   p1.Date != p2.Date;
        }
        #endregion
    }
}

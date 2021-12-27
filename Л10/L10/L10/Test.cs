using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L10
{
    public class Test : IDateAndCopy
    {
        #region properties
        public string Subject { get; set; }
        public bool Pass { get; set; }
        
        public DateTime Date { get; set; }
        #endregion

        #region contstruct
        public Test(string subject, bool pass)
        {
            Subject = subject;
            Pass = pass;
        }

        public Test()
        {
            Subject = "Math";
            Pass = true;
        }
        #endregion

        #region methods
        public override string ToString()
        {
            return $" {Subject} Passed {Pass}";
        }
        
        public object DeepCopy()
        {
            return new Test
            {
                Subject = Subject,
                Pass = Pass,
            };
        }
        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9L
{
    internal interface IDateAndCopy
    {
        object DeepCopy();
        DateTime Date { get; set; }
        
    }
}

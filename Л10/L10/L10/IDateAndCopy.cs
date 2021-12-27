using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L10
{
    internal interface IDateAndCopy
    {
        object DeepCopy();
        DateTime Date { get; set; }
        
    }
}

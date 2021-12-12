using System.Collections.Generic;
using System.IO;
using System.Runtime.ConstrainedExecution;
using System.Text.Json;
using System.Runtime.Serialization.Formatters.Binary;

using System;

namespace L12
{
    
    public class Teacher
    {
        public string LastName { get; set; }
        public string Discipline { get; set; }
        public int Seniority { get; set; }


    }
}
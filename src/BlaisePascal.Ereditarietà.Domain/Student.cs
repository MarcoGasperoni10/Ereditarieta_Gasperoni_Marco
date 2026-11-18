using System;
using System.Collections.Generic;
using System.Text;

namespace BlaisePascal.Ereditarietà.Domain
{
    public class Student : Person
    {
        public double Average { get; private set; }
        public Student(string name, string surname, double avg) : base(name, surname)
        {
            Average = avg;
        }

        public override string Print()
        {
            return base.Print() + " " + Average.ToString();
        }
    }
}

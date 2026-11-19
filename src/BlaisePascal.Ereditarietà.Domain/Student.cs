using System;
using System.Collections.Generic;
using System.Text;

namespace BlaisePascal.Ereditarietà.Domain
{
    public class Student : Person
    {
        private double _average;

        public double Average
        {
            get
            {
                return _average;
            }
            set
            {
                if (value < 0.0 || value > 10.0)
                    throw new ArgumentException("Error: average must be within 0.0 and 10.0.");
            }
        }
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

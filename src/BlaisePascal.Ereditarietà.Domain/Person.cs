using System.Xml.Linq;

namespace BlaisePascal.Ereditarietà.Domain
{
    public class Person
    {
        private string _name;
        private string _surname;
        public string Name 
        {
            get
            {
                return _name;
            }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Error: name must not be empty or blank.");
                _name = value;
            }
        }

        public string Surname
        {
            get
            {
                return _surname;
            }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Error: surname must not be empty or blank.");
                _surname = value;
            }
        }

        public Person(string name, string surname)
        {
            Name = name;
            Surname = surname;
        }

        public virtual string Print()
        {
            return Name + " " + Surname;
        }
    }
}

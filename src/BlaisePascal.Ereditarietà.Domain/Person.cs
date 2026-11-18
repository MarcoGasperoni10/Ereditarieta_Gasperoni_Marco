namespace BlaisePascal.Ereditarietà.Domain
{
    public class Person
    {
        public string Name { get; private set; }

        public string Surname { get; private set; }

        public Person(string name, string surname)
        {
            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(surname))
                throw new ArgumentException("Error: name and surname must not be empty or blank.");
            Name = name;
            Surname = surname;
        }

        public virtual string Print()
        {
            return Name + " " + Surname;
        }
    }
}

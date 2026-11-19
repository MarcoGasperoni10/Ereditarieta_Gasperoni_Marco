using BlaisePascal.Ereditarietà.Domain;

namespace BlaisePascal.Ereditarietà.UIConsole
{
    public class Program
    {
        public static void Main()
        {
            Person person = new Person("Gaia", "Pizzigati");
            Student student = new Student("Mattia", "Viscusi", 2.3);
            Person personStudent = new Student("Alice", "Tani", 7.3);

            Console.WriteLine(person.Print());
            Console.WriteLine(student.Print());
            Console.WriteLine(personStudent.Print());

            if (personStudent is Student)
            {
                Student s = personStudent as Student;
                double avg = s.Average;
            }
        }
    }
}
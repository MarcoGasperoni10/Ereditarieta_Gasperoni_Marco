using BlaisePascal.Ereditarietà.Domain;

namespace BlaisePascal.Ereditarietà.UIConsole
{
    public class Program
    {
        public static void Main()
        {
            Person p = new Person("Gaia", "Pizzigati");
            Student s = new Student("Mattia", "Viscusi", 2.3);
            Person ps = new Student("Alice", "Tani", 7.3);

            Console.WriteLine(p.Print());
            Console.WriteLine(s.Print());
            Console.WriteLine(ps.Print());
        }
    }
}
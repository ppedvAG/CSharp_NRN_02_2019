using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hochzeitssimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person(Person.Geschlechter.Männlich, "Robert", "Petzold", DateTime.Parse("22.02.1986"));

            Console.WriteLine(p1.Geburtstag);
            Console.WriteLine($"Alter: {p1.Alter}");
            //TODO: Vollständiger Name als Getter-Property
            Console.WriteLine($"{p1.Name}, {p1.Alter} Jahre.");
            Console.ReadKey();
        }
    }
}

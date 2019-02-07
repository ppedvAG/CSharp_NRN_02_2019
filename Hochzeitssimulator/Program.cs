using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Hochzeitssimulator
{
    class Program
    {
        static void Main(string[] args)
        {


            Person.GleichgeschlechtlichErlaubt = true;

            Person p1 = new Person(Person.Geschlechter.Männlich, "Robert", "Petzold", DateTime.Parse("22.02.1986"));

            Person p2 = new Person(Person.Geschlechter.Weiblich, "Anja", "Müller", DateTime.Parse("22.01.1986"));

            

            p1.Heirate(p2);
            p1.Heirate(p2);
            Console.WriteLine($"Ehepartner von p1: {p1.Ehepartner.Name}.");
            Console.WriteLine($"Ehepartner von p2: {p2.Ehepartner.Name}.");

            p1.ScheideDich();
            p1.ScheideDich();


            Console.WriteLine($"Ehepartner von p1: {p1.Ehepartner}.");
            Console.WriteLine($"Ehepartner von p2: {p2.Ehepartner}.");

            Console.WriteLine("Alle private Felder von Klasse Person:");
            foreach (var item in p1.GetType().GetFields(BindingFlags.NonPublic | BindingFlags.Instance))
            {
                Console.WriteLine($"\t{item.Name}");
            }
            

            Console.ReadKey();
        }
    }
}

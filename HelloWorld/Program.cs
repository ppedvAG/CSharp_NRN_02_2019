using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hello World!\n");

            //snippet: cw
            Console.Write("Bitte gib deinen Namen ein: ");
            
            string name = Console.ReadLine();
            

            Console.WriteLine("Hallo " + name + ", viel Erfolg mit C#!");
            Console.WriteLine("Hallo {0}, viel Erfolg mit C#!", name);
            //Interpolierten Strings
            Console.WriteLine($"Hallo {name}, viel Erfolg mit C#!");

            Console.Write("Alter 1: ");
            int alter1 = int.Parse(Console.ReadLine());

            Console.Write("Alter 2: ");
            int alter2 = int.Parse(Console.ReadLine());
            
            string zahlAlsWort = (15).ToString();
            Console.WriteLine($"Maximal Wert eines Integers: {int.MaxValue}");

            Console.WriteLine($"Durchschnittsalter: {(alter1 + (double)alter2) / 2}");

            Console.ReadKey();
        }
    }
}

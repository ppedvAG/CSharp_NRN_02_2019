using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaumKlassen
{
    class Program
    {
        static void Main(string[] args)
        {
            Tisch t1 = new Tisch();
            t1.anzahlFüße = 4;

            Stuhl s1 = new Stuhl();
            Stuhl s2 = new Stuhl();

            Person p1 = new Person();
            p1.name = "Max Mustermann";
            p1.alter = 15;


            p1.SetzeDich(s1);

            p1.stuhl.anzahlFüße = 5;

            Console.WriteLine( p1.stuhl.sitzer.stuhl.sitzer.stuhl.sitzer.name);

            Stuhl[] stühle = new Stuhl[] { s1, s2, s1 };

            t1.stühle = stühle;
        }
    }
}

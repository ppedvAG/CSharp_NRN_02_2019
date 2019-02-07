using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{

    class Program
    {

        //Definition der Delegate-Typen
        public delegate void MethodeMitEinemString(string m);
        public delegate int MethodeMit2Parametern(int i1, int i2, ref int i3);

        static void Main(string[] args)
        {
        
            //Deklaration einer Delegate-Variablen und Zuweisung einer passenden Methode
            MethodeMitEinemString delegateVariable = SchreibeEtwas;
            //Eine weitere Methode zur Methodenliste der DelegateVariablen hinzufügen
            delegateVariable += SchreibeDoppelt;


            //Deklaration einer Delegate-Variablen und Zuweisung einer passenden Methode
            MethodeMit2Parametern delegateVariable2 = Berechne;
            //Die gleiche Methode zur Methodenliste der DelegateVariablen hinzufügen
            delegateVariable2 += Berechne;


            //Aufruf aller Methoden, die in dem Moment von der Delegate-Variablen referenziert sind
            delegateVariable("etwas");


            int summe = 0;

            //Alle hinzugefügten Methoden werden hintereinander ausgeführt
            delegateVariable2(2, 5, ref summe);

            //Ausführung mit vorheriger Null-Prüfung
            //delegateVariable2?.Invoke(2, 5, ref summe);

            Console.WriteLine($"Summe: {summe}");

            //Generische Delegate-Typen
            Action<string> delegateVar = SchreibeEtwas;
            Func<int, int, int> delegateV = BerechneOhneRef;

            delegateVar("asdsad");

            Predicate<int> EinParameterRückgabewertBool = IstGerade;

            Console.ReadKey();
        }

        public static void SchreibeEtwas(string message)
        {
            Console.WriteLine($"Schreibe: {message}");
        }

        public static void SchreibeDoppelt(string message)
        {
            Console.WriteLine($"Schreibe: {message} {message}");
        }

        public static int Berechne(int z1, int z2, ref int summe)
        {
            Console.WriteLine($"Summe :{z1 + z2}");
            summe += (z1 + z2);
            return summe;
        }

        public static int BerechneOhneRef(int z1, int z2)
        {
            Console.WriteLine($"Summe :{z1 + z2}");
            return z1 + z2;
        }

        public static bool IstGerade(int z1)
        {
            return (z1 % 2) == 0;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taschenrechner
{
    class Program
    {
        enum Rechenoperationen { Addition, Subtraktion, Division, Multiplikation }

        static void Main(string[] args)
        {
            Berechne(2, 5, Rechenoperationen.Addition);


            Berechne(10, 5, Rechenoperationen.Subtraktion);

            double ergebnis = Berechne(10, 0, Rechenoperationen.Division);
            Console.WriteLine($"10 / 0: {ergebnis}");

            Console.WriteLine($"Unendlich + 1: {ergebnis + 1}");




            if(BerechneOut(10, 0, Rechenoperationen.Division, out double erg) == true)
            {
                Console.WriteLine($"Ergebnis: {erg}");
            }
            else
            {
                Console.WriteLine("Fehler in der Aufgabe!");
            }

            int geparsteZahl;


            while (!int.TryParse(Console.ReadLine(), out geparsteZahl))
            {
                Console.WriteLine("Ungültige Zahl!");
            }

            Console.WriteLine($"{geparsteZahl} wurde geparst!");

            if (int.TryParse(Console.ReadLine(), out geparsteZahl))
            {
                Console.WriteLine($"{geparsteZahl} wurde geparst!");
            }
            else
            {
                Console.WriteLine("Ungültige Zahl!");
            }

            Console.ReadKey();
        }




        static bool BerechneOut(double zahl1, double zahl2, Rechenoperationen operation, out double ergebnis)
        {
            ergebnis = 0;

            switch (operation)
            {
                case Rechenoperationen.Addition:
                    ergebnis = zahl1 + zahl2;
                    return true;
                case Rechenoperationen.Subtraktion:
                    ergebnis = zahl1 - zahl2;
                    return true;
                case Rechenoperationen.Division:
                    if (zahl2 == 0)
                    {
                        return false;
                    }
                    ergebnis = zahl1 / zahl2;
                    return true;
                case Rechenoperationen.Multiplikation:
                    ergebnis = zahl1 * zahl2;
                    return true;
                default:
                    break;
            }

            throw new Exception("Unbekannte Operation");
        }







        static double Berechne(double zahl1, double zahl2, Rechenoperationen operation)
        {
            switch (operation)
            {
                case Rechenoperationen.Addition:
                    return zahl1 + zahl2;
                case Rechenoperationen.Subtraktion:
                    return zahl1 - zahl2;
                case Rechenoperationen.Division:
                    if(zahl2 == 0)
                    {
                        throw new DivideByZeroException("Division durch 0 ist nicht erlaubt");
                    }
                    return zahl1 / zahl2;
                case Rechenoperationen.Multiplikation:
                    return zahl1 * zahl2;
                default:
                    break;
            }

            throw new Exception("Unbekannte Operation");
        }

    }
}

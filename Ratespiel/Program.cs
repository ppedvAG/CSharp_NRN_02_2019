using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ratespiel
{
    class Program
    {
        static void Main(string[] args)
        {
            //Zufällige Zahl zwischen 1 und 10 generiert werden

            //Zufallsgenerator bauen
            Random random = new Random();

            int zufallszahl = random.Next(1, 11);
            int gerateneZahl;
            bool sds;
            int versuche = 0;


            #region Variante mit break
            //while (true)
            //{
            //    Console.Write("Bitte rate eine Zahl zwischen 1 und 10: ");
            //    gerateneZahl = int.Parse(Console.ReadLine());

            //    versuche++;

            //    if (gerateneZahl > zufallszahl)
            //    {
            //        Console.WriteLine("Zahl war zu groß!");
            //    }
            //    else if (gerateneZahl < zufallszahl)
            //    {
            //        Console.WriteLine("Zahl war zu klein!");

            //    }
            //    else
            //    {
            //        break;
            //    }
            //}
            #endregion


            do
            {
                Console.Write("Bitte rate eine Zahl zwischen 1 und 10: ");
                gerateneZahl = int.Parse(Console.ReadLine());

                if(gerateneZahl > zufallszahl)
                {
                    Console.WriteLine("Zahl war zu groß!");
                }
                else if(gerateneZahl < zufallszahl)
                {
                    Console.WriteLine("Zahl war zu klein!");

                }
                versuche++;

            } while (zufallszahl != gerateneZahl);

            Console.WriteLine($"Du hast die richtige Zahl getippt und dafür {versuche} Versuche gebraucht!");

            Console.WriteLine($"Die zu ratende Zahl war {zufallszahl}");

            Console.ReadKey();
        }
    }
}

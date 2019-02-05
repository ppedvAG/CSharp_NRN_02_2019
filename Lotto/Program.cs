using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lotto
{
    class Program
    {
        /// <summary>
        /// Von 1 bis inklusive Limit
        /// </summary>
        const int Obere_Limit = 6;

        /// <summary>
        /// Wie viele Zahlen sollen gezogen werden?
        /// </summary>
        const int Anzahl_Zu_Ziehende_Zahlen = 6;

        static void Main(string[] args)
        {
            #region Wenn auch die Zahl 0 gezogenen werden soll...
            //Default-Wert eines Datentyps ermitteln
            //Console.WriteLine(default(int[]));
            //for (int i = 0; i < Anzahl_Zu_Ziehende_Zahlen; i++)
            //{
            //    gezogenenZahlen[i] = -1;
            //}
            #endregion
           
            //mehrdimensionale Arrays; int[,] array = new int[2,5];

            //Arrays müssen bei der Initialisierung eine feste Größe bekommen!
            int[] gezogenenZahlen = new int[Anzahl_Zu_Ziehende_Zahlen];
            int[] getippteZahlen = new int[gezogenenZahlen.Length];

            //1. Zahlen tippen
            for (int i = 0; i < Anzahl_Zu_Ziehende_Zahlen; i++)
            {
                //TODO: sinnlose Werte abfangen

                Console.Write($"Geben Sie eine Zahl zwischen 1 und {Obere_Limit} ein: ");
                getippteZahlen[i] = int.Parse(Console.ReadLine());
            }

            //2. Zahlen ziehen
            Random random = new Random();
            for (int i = 0; i < Anzahl_Zu_Ziehende_Zahlen; i++)
            {
                //TODO: doppelte Zahlen vermeiden
                int potentielleNeueZahl;

                do
                {
                    potentielleNeueZahl = random.Next(1, Obere_Limit + 1);
                } while (gezogenenZahlen.Contains(potentielleNeueZahl));

                //if(gezogenenZahlen.Contains(potentielleNeueZahl))
                //{
                //    i--;
                //    continue;
                //}

                gezogenenZahlen[i] = potentielleNeueZahl;

                Console.WriteLine(gezogenenZahlen[i]);
            }

            
            //3. Auswertung (Anzahl der Treffer ermitteln)

            int treffer = 0;

            for (int i = 0; i < Anzahl_Zu_Ziehende_Zahlen; i++)
            {
                if(getippteZahlen.Contains(gezogenenZahlen[i]))
                {
                    treffer++;
                }
            }

            
            Console.WriteLine($"Du hattest {treffer} richtige Zahlen!");

            Console.ReadKey();

            //Bonus:
            //Ausschließen das doppelte Zahlen gezogen werden
            //Was passiert bei Limit 6 und 6 zu ziehenden Zahlen?
            //Prüfen ob Nutzer eine zu große oder kleine Zahl eingegeben hat?
        }
    }
}

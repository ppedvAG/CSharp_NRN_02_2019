using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FloatHelper
{
    public static class Floats
    {
        #region Andere Erweiterungsmethoden
        public static int BetterNext(this Random r, int untereschranke, int obereschranke)
        {
            return r.Next(untereschranke, obereschranke + 1);
        }

        public static int Quersumme(this int zahl)
        {
            string ziffern = zahl.ToString();
            int summe = 0;
            foreach (var ziffer in ziffern)
            {
                summe += 20;
            }

            Random random = new Random();
            random.BetterNext(1, 49);

            return summe;
        }
        #endregion

        public static int Nachkommastellen = 2;

        //Addieren
        public static float Add(this float z1, float z2)
        {
            return z1.Add(z2, Nachkommastellen);
        }

        //Überladung
        public static float Add(this float z1, float z2, int nachkommastellen)
        {
            return (float)Math.Round((double)z1 + (double)z2, nachkommastellen);
        }

        //Subtrahieren
        public static float Sub(this float z1, float z2)
        {
            return z1.Sub(z2, Nachkommastellen);
        }

        //Überladung
        public static float Sub(this float z1, float z2, int nachkommastellen)
        {
            return (float)Math.Round((double)z1 - (double)z2, nachkommastellen);
        }
    }
}

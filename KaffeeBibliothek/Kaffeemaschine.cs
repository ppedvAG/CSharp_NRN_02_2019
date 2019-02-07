using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FloatHelper;

namespace KaffeeBibliothek
{
    public abstract class Kaffeemaschine
    {

        //Event ist ein Zugriffsmodifizierer
        //Von außen kann das Event nicht mehr gefeuert werden
        // Bedienungsfehler = null oder Bedienungsfehler = methode ist von außen nicht möglich
        public event Action<string> Bedienungsfehler;

        //Abstraktes Property, kann in den vererbten Klassen überschrieben werden
        public abstract Bestellung.Kaffeearten Produziert { get; }



        /// <summary>
        /// Wasserkapazität in Litern
        /// </summary>
        public static float Wasserkapazität { get; set; } = 1.0f;

        /// <summary>
        /// Wasserstand in Litern
        /// </summary>
        public float Wasserstand { get; private set; } = 0.0f;

        public void FülleWasserEin(float menge)
        {
            if (Wasserstand.Add(menge) > Kaffeemaschine.Wasserkapazität)
            {
                Bedienungsfehler?.Invoke("Zu viel Wasser");
                Wasserstand = Kaffeemaschine.Wasserkapazität;
            }
            else
            {
                //Wasserstand = Wasserstand + menge
                Wasserstand = Wasserstand.Add(menge);
            }
        }

        //Kontruktoren
        public Kaffeemaschine(float startWassertstand)
        {
            FülleWasserEin(startWassertstand);
        }

        //Andere Methoden
        public virtual bool BereiteZu(float zuProduzierendeMenge)
        {
            if (Wasserstand < zuProduzierendeMenge)
            {
                Bedienungsfehler?.Invoke("Zu wenig Wasser");
                return false;
            }

            Wasserstand = Wasserstand.Sub(zuProduzierendeMenge);

            return true;
        }

        public override string ToString()
        {
            return $"Wasserstand: {Wasserstand:0.00} \\ {Wasserkapazität:0.00} Liter";
        }

        protected void OnFehlerereignis(string grund)
        {
            Bedienungsfehler?.Invoke(grund);
        }
    }
}

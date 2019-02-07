
using FloatHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaffeeBibliothek
{
    //Alt+Enter
    public class Filtermaschine : Kaffeemaschine
    {
        public static float Kaffeekapazität { get; set; } = 1;

        public override Bestellung.Kaffeearten Produziert
        {
            get
            {
                return Bestellung.Kaffeearten.Filterkaffee;
            }
        }

        public float Kaffeemenge { get; private set; } = 0;

        public Filtermaschine(float startWassertstand) : base(startWassertstand)
        {

        }

        public void FülleKaffeEin(float menge)
        {
            if (Kaffeemenge.Add(menge) > Filtermaschine.Kaffeekapazität)
            {
                OnFehlerereignis("Zu viel Kaffee!");
                Kaffeemenge = Filtermaschine.Kaffeekapazität;
            }
            else
            {
                Kaffeemenge = Kaffeemenge.Add(menge);
            }
        }

        public override string ToString()
        {
            return $"{base.ToString()}\nKaffeemenge: {Kaffeemenge:0.00} \\ {Kaffeekapazität} Kilo";
        }

        public override bool BereiteZu(float zuProduzierendeMenge)
        {
            if (Kaffeemenge < zuProduzierendeMenge)
            {
                OnFehlerereignis("Zu wenig Kaffee!");
                return false;
            }

            if (base.BereiteZu(zuProduzierendeMenge))
            {
                Kaffeemenge = Kaffeemenge.Sub(zuProduzierendeMenge);
                return true;
            }
            return false;
        }
    }
}
using FloatHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaffeeBibliothek
{
    public class Vollautomat : Filtermaschine
    {
        public override Bestellung.Kaffeearten Produziert
        {
            get
            {
                return Bestellung.Kaffeearten.Cappuccino;
            }
        }

        public static float Milchkapazität { get; set; } = 1;

        public float Milchmenge { get; private set; } = 0;

        public Vollautomat(float startWassertstand) : base(startWassertstand)
        {

        }

        public void FülleMilchEin(float menge)
        {
            if (Milchmenge.Add(menge) > Vollautomat.Milchkapazität)
            {
                OnFehlerereignis("Zu viel Milch!");
                Milchmenge = Vollautomat.Milchkapazität;
            }
            else
            {
                Milchmenge = Milchmenge.Add(menge);
            }
        }

        public override string ToString()
        {
            return $"{base.ToString()}\nMilchmenge: {Milchmenge:0.00} \\ {Milchkapazität} Liter";
        }

        public override bool BereiteZu(float zuProduzierendeMenge)
        {
            if (Milchmenge < zuProduzierendeMenge)
            {
                OnFehlerereignis("Zu wenig Milch!");
                return false;
            }

            if (base.BereiteZu(zuProduzierendeMenge))
            {
                Milchmenge = Milchmenge.Add(zuProduzierendeMenge);
                return true;
            }
            return false;
        }
    }
}

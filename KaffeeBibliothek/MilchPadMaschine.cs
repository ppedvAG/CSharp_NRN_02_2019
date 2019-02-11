using FloatHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaffeeBibliothek
{

    public class MilchPadMaschine : PadMaschine, IMilchEinfüllbar
    {

        public override Bestellung.Kaffeearten Produziert
        {
            get
            {
                return Bestellung.Kaffeearten.EspressoMacchiato;
            }
        }

        public float Milchmenge { get; private set; } = 0;

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


        public MilchPadMaschine(float startWassermenge) : base(startWassermenge)
        {
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

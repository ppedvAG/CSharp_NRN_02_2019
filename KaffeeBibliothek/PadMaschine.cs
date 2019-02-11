using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaffeeBibliothek
{
    public class PadMaschine : Kaffeemaschine
    {
        public override Bestellung.Kaffeearten Produziert
        {
            get
            {
                return Bestellung.Kaffeearten.Espresso;
            }
        }

        //snippet: propfull
        private bool _padEingelegt = false;

        public bool PadEingelegt
        {
            get { return _padEingelegt; }
            set
            {
                if(_padEingelegt && value)
                {
                    OnFehlerereignis("Pad liegt schon drin!");
                    return;
                }
                _padEingelegt = value;
            }
        }

        public PadMaschine(float startWassermenge) : base(startWassermenge)
        {
           
        }

        public override string ToString()
        {
            string eingelegtePads = "0";
            if (PadEingelegt)
                eingelegtePads = "1";

            #region Kurzschreibweise
            //string eingelegtePads = PadEingelegt ? "1" : "0";
            #endregion

            return $"{base.ToString()}\nEingelegte Pads: {eingelegtePads}";
        }

        public override bool BereiteZu(float zuProduzierendeMenge)
        {
            if (!PadEingelegt)
            {
                OnFehlerereignis("Es ist kein Pad eingelegt!");
                return false;
            }

            if (base.BereiteZu(zuProduzierendeMenge))
            {
                PadEingelegt = false;
                return true;
            }
            return false;
        }
    }
}
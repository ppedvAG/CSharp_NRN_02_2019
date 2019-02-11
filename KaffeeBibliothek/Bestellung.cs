using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaffeeBibliothek
{
    public class Bestellung
    {
        public enum Kaffeearten { Filterkaffee, Cappuccino, Espresso, EspressoMacchiato }

        public float Menge { get; private set; }
        public Kaffeearten Kaffeeart { get; private set; }

        public Bestellung(float menge, Kaffeearten kaffeeart)
        {
            Menge = menge;
            Kaffeeart = kaffeeart;
        }
    }
}

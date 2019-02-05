using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaumKlassen
{
    public class Stuhl
    {
        public enum Materialarten { Leder, Holz, Metall}

        //🥑🥑
        public int anzahlFüße;
        public Materialarten material;

        public Person sitzer;


    }
}

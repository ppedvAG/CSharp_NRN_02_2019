using System;

namespace RaumKlassen
{
    public class Person
    {
        //Felder
        public string name;
        public int alter;
        public Stuhl stuhl;

        public string stuhlname;
        public string anzahlfüßestuhls;

        //Methoden
        public bool SetzeDich(Stuhl s)
        {
            //null: keine Speicheradresse
            if(s.sitzer != null)
            {
                Console.WriteLine("Stuhl ist schon besetzt!");
                return false;
            }

            stuhl = s;
            //this ist die Referenz auf das Objekt, von dem aus diese Funktion aufgerufen wurde
            s.sitzer = this;
            return true;
        }
    }
}
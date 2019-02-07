using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hochzeitssimulator
{
    public class Person
    {

        public enum Geschlechter { Männlich, Weiblich, Divers }

        //statische Properties, werden nur 1 Mal pro Klasse gespeichert, sind unabhängig vom jeweiligen Objekt
           
        public static Geschlechter[] MöglicheGeschlechter = new Geschlechter[] { Geschlechter.Männlich, Geschlechter.Weiblich, Geschlechter.Divers };
        public static bool GleichgeschlechtlichErlaubt { get; set; } = false;
        public static int DurchschnittlicheLebensdauer = 80;
        public static int AnzahlPersonen;

        //dynamische (non-static) Properties: werden für jedes Objekt extra gespeichert

        //snippet: prop (Property)
        public Geschlechter Geschlecht { get; private set; }

        public string Vorname { get; private set; }

        public string Nachname { get; private set; }

        private DateTime _geburtstag;
        public DateTime Geburtstag
        {
            get
            {
                return _geburtstag;
            }
            private set
            {
                if(value > DateTime.Now)
                {
                    throw new Exception("Geburtstag darf nicht in der Zukunft liegen");
                }
                _geburtstag = value;
            }
        }

        private Person _ehepartner;
        public Person Ehepartner
        {
            //Person Ehepartner(), wird bei lesendem Zugriff aufgerufen
            get { return _ehepartner; }

            //void Ehepartner(Person value), wird bei schreibenden Zugriff aufgerufen
            private set
            {
                //value steht für den Wert, der zugewiesen wurde
                if (_ehepartner != null)
                {
                    _ehepartner._ehepartner = value;
                    _ehepartner = value;
                }
                else
                {

                    _ehepartner = value;

                    if (_ehepartner != null)
                        _ehepartner._ehepartner = this;
                }
            }
        }

        //Getter-Property
        public int Alter
        {
            //Getter-Methode
            get
            {
                //Strg+K+D: Automatische Formatierungs
                return DateTime.Now.Year - Geburtstag.Year;
            }
        }

        //Getter-Property
        public string Name
        {
            get
            {
                return $"{Vorname} {Nachname}";
            }
        }

        public bool Verheiratet
        {
            get
            {
                if (Ehepartner == null)
                    return false;
                else
                    return true;
            }
        }

        //Konstuktor
        public Person(Geschlechter geschlecht, string vorname, string nachname, DateTime geburtstag)
        {
            Geschlecht = geschlecht;
            Vorname = vorname;
            Nachname = nachname;
            Geburtstag = geburtstag;
        }

        //Methoden
        public bool Heirate(Person zuHeiratendePerson)
        {
            //Ungültige Hochzeiteiten ausschließen

            //zu heiratende Person ist leer
            if (zuHeiratendePerson == null)
            {
                Console.WriteLine("Zu heiratende Person existiert nicht!");
                return false;
            }

            //Sich selbst heiraten
            if (this == zuHeiratendePerson)
            {
                Console.WriteLine("Selbstheirat verboten");
                return false;
            }

            //Einer ist nicht volljährig
            if (this.Alter < 18 || zuHeiratendePerson.Alter < 18)
            {
                Console.WriteLine("Selbstheirat verboten");
                return false;
            }

            //Einer der beiden ist schon verheiratet
            if (zuHeiratendePerson.Verheiratet || this.Verheiratet)
            {
                Console.WriteLine("Vielehe verboten");
                return false;
            }

            //Optional: Geschlecht berücksichtigen je nach Land
            if(!Person.GleichgeschlechtlichErlaubt && this.Geschlecht == zuHeiratendePerson.Geschlecht)
            {
                Console.WriteLine("Gleichgeschlechtliche Ehe verboten!");
                return false;
            }

            //Heirat vollziehen
            Ehepartner = zuHeiratendePerson;
            return true;
        }

        public void ScheideDich()
        {
            //if(Ehepartner != null)
            Ehepartner = null;
        }

    }
}

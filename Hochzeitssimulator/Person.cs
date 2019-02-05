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

        //snippet: prop (Property)
        public Geschlechter Geschlecht { get; private set; }

        public string Vorname { get; private set; }
        public string Nachname { get; private set; }

        public DateTime Geburtstag { get; private set; }

        public Person Ehepartner { get; private set; }

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
        public bool Heirate(Person p1)
        {
            //Ungültige Hochzeiteiten ausschließen

            //zu heiratende Person ist leer
            if (p1 == null)
            {
                Console.WriteLine("Zu heiratende Person existiert nicht!");
                return false;
            }

            //Sich selbst heiraten
            if (this == p1)
            {
                Console.WriteLine("Selbstheirat verboten");
                return false;
            }

            //Einer ist nicht volljährig
            if (this.Alter < 18 || p1.Alter < 18)
            {
                Console.WriteLine("Selbstheirat verboten");
                return false;
            }

            //Einer der beiden ist schon verheiratet
            if(p1.Verheiratet || this.Verheiratet)
            {
                Console.WriteLine("Vielehe verboten");
                return false;
            }
            
            

            //Optional: Geschlecht berücksichtigen je nach Land


            //Heirat vollziehen

        }

    }
}

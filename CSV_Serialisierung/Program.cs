using ServiceStack.Text;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSV_Serialisierung
{
    class Program
    {
        private const string Path = "Maschinenliste.csv";

        static void Main(string[] args)
        {

            Console.WriteLine("Was möchtest du tun?");
            Console.WriteLine("0: Lokale Maschinenliste als csv speichern");
            Console.WriteLine($"1: {Path} einlesen (deserialisieren");

            ConsoleKey key = Console.ReadKey().Key;
            Console.WriteLine();

            switch (key)
            {
                case ConsoleKey.D0:
                case ConsoleKey.NumPad0:
                    //Lokale Maschinenliste als csv speichern
                    List<Maschine> maschinenliste = new List<Maschine>()
                    {
                        new Maschine("Staubsauger"),
                        new Maschine("Bügeleisen"),
                        new Maschine("Wasserkocher", true)
                    };
                    //Nuget Package ServiceStack.Text herunterladen
                    string csvString = CsvSerializer.SerializeToCsv(maschinenliste);
                    using (StreamWriter writer = new StreamWriter(Path))
                    {
                        writer.Write(csvString);
                    }
                    Console.WriteLine($"{Path} wurde mit folgendem Inhalt gespeichert: {csvString}");
                    break;
                case ConsoleKey.D1:
                case ConsoleKey.NumPad1:
                    //CSV-Datei deserialisieren
                    if(!File.Exists(Path))
                    {
                        Console.WriteLine($"Datei {Path} existiert nicht!");
                        return;
                    }
                    using (StreamReader reader = new StreamReader(Path)) 
                    {
                        string csv = reader.ReadToEnd();
                        List<Maschine> maschinen = CsvSerializer.DeserializeFromString<List<Maschine>>(csv);
                        Console.WriteLine($"{Path} wurde erfolgreich deserialisiert. Inhalt:");
                        foreach (var item in maschinen)
                        {
                            Console.WriteLine(item);
                        }
                    }
                    break;
            }

            Console.ReadKey();
        }
    }

    public class Maschine
    {

        public string Name { get; set; }
        public bool Gebraucht { get; set; }

        public Maschine(string name, bool gebraucht = false)
        {
            Name = name;
            Gebraucht = gebraucht;
        }

        public override string ToString()
        {
            string gebraucht = Gebraucht ? "gebraucht" : "neu";
            return $"{Name} ({gebraucht})";
        }
    }
}

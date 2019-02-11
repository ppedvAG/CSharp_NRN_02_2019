using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace MisterBarista
{
    public static class HighscoreManager
    {
        public const string File_Name = "CoffeeHighscore.chs";

        //Generische Datentypen
        public static BindingList<HighscoreEintrag> HighscoreListe { get; set; }

        //Statischer Konstruktor: 1 Mal pro Programmausführung aufgerufen
        static HighscoreManager()
        {
            if (File.Exists(File_Name))
            {

                
                StreamReader reader = null;
                try
                {
                    reader = new StreamReader(File_Name);
                    string json = reader.ReadToEnd();
                    //reader.Close();
                    HighscoreListe = JsonConvert.DeserializeObject<BindingList<HighscoreEintrag>>(json);
                    reader.Dispose();
                }
                catch (Exception exp)
                {
                    MessageBox.Show(exp.Message);
                    reader?.Dispose();
                    return;
                }
                finally
                {
                    reader?.Close();
                }


                //using (StreamReader reader = new StreamReader(File_Name))
                //{

                //}
            }
            else
            {
                HighscoreListe = new BindingList<HighscoreEintrag>();
            }
        }


        public static void Speichern()
        {
            //Liste sortieren mit Linq


            //HighscoreListe.OrderByDescending(SortierKriterium);



            var sortierteListe = HighscoreListe.OrderByDescending(eintrag => eintrag.Score).ToList();

            //Kopierkonstruktor
            HighscoreListe = new BindingList<HighscoreEintrag>(sortierteListe);

            //HighscoreListe.OrderByDescending(eintrag => eintrag.Score).ToList().ForEach(eintrag => MessageBox.Show(eintrag.Name));


            string json = JsonConvert.SerializeObject(HighscoreListe);
            //TODO: using verwenden
            StreamWriter writer = new StreamWriter(File_Name, false);
            writer.Write(json);
            writer.Close();
        }

        //public static int SortierKriterium(HighscoreEintrag eintrag)
        //{
        //    return eintrag.Score;
        //}
    }

    public class HighscoreEintrag
    {
        public string Name { get; private set; }

        public int Score { get; private set; }
        public DateTime Datum { get; private set; }

        public HighscoreEintrag(string name, int score) : this(name, score, DateTime.Now)
        {

        }

        //Attribute, die per Reflection von anderen Klassen ausgewertet
        //In diesem Fall: teilt dem Deserialisierer mit, welchen Konsturktor er benutzen soll
        [JsonConstructor]
        public HighscoreEintrag(string name, int score, DateTime datum)
        {
            Name = name;
            Score = score;
            Datum = datum;
        }

        public override string ToString()
        {
            return $"{Name}\t\t{Score} ({Datum})";
        }
    }
}

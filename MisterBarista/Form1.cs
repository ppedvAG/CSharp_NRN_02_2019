using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KaffeeBibliothek;

namespace MisterBarista
{
    public enum KaffeemaschinenArten { Filtermaschine, PadMaschine, Vollautomat }

    public partial class Form1 : Form
    {
        Filtermaschine _filterMaschine;
        PadMaschine _padMaschine;
        Vollautomat _vollautomat;
        Kaffeemaschine _ausgewählteMaschine;
        Random _random = new Random();

        Bestellung _aktuelleBestellung;

        public Form1()
        {
            InitializeComponent();
            //Maschinen initialisieren/instantiieren
            _filterMaschine = new Filtermaschine(0);
            _padMaschine = new PadMaschine(0);
            _vollautomat = new Vollautomat(0.5f);

            //Event-Handler für das Ergeignis Bedienungsfehler registrieren
            _filterMaschine.Bedienungsfehler += FehlerIstAufgetreten;
            _padMaschine.Bedienungsfehler += FehlerIstAufgetreten;
            _vollautomat.Bedienungsfehler += FehlerIstAufgetreten;

            //Neue Bestellung erzeugen
            GeneriereNeueBestellung();

            labelBedienungsfehler.Visible = false;
        }

        private void GeneriereNeueBestellung()
        {
            //Zufällige Bestellung erzeugen

            //Arrays befüllen
            float[] möglicheMengen = new float[] { 0.1f, 0.2f, 0.3f, 0.4f };
          
            Bestellung.Kaffeearten[] möglicheKaffeearten = new Bestellung.Kaffeearten[] 
            {
                Bestellung.Kaffeearten.Cappuccino,
                Bestellung.Kaffeearten.Espresso,
                Bestellung.Kaffeearten.Filterkaffee,
            };

            #region Array automatisch generieren
            //Array array = Enum.GetValues(typeof(Bestellung.Kaffeearten));
            //List<Bestellung.Kaffeearten> arten = new List<Bestellung.Kaffeearten>();
            //foreach (var item in array)
            //{
            //    arten.Add((Bestellung.Kaffeearten)item);
            //}
            #endregion

            //Zufälligen Eintrag im Mengen-Array auswählen
            int zufälligerIndex = _random.Next(0, möglicheMengen.Length);
            float menge = möglicheMengen[zufälligerIndex];

            //Zufälligen Eintrag im Kaffeearten-Array auswählen
            zufälligerIndex = _random.Next(0, möglicheKaffeearten.Length);
            Bestellung.Kaffeearten kaffeeart = möglicheKaffeearten[zufälligerIndex];

            //Bestellung erzeugen und auf Klassen-Feld zuweisen
            _aktuelleBestellung = new Bestellung(menge, kaffeeart);

            //Bestellung anzeigen
            labelBestellung.Text = $"{_aktuelleBestellung.Menge} Liter {_aktuelleBestellung.Kaffeeart} bitte!"; 
        }

        //Event-Handler
        private void FehlerIstAufgetreten(string fehlermeldung)
        {
            //Was soll bei einem Bedienungsfehler passieren?
            labelBedienungsfehler.Visible = true;
            labelBedienungsfehler.Text = fehlermeldung;
        }

        private void Formular_Wurde_Geladen(object sender, EventArgs e)
        {
            #region Händisches Hinzufügen
            //listBoxKaffeemaschinen.Items.Add(KaffeemaschinenArten.Filtermaschine);
            //listBoxKaffeemaschinen.Items.Add(KaffeemaschinenArten.PadMaschine);
            //listBoxKaffeemaschinen.Items.Add(KaffeemaschinenArten.Vollautomat);
            #endregion

            foreach (var item in Enum.GetValues(typeof(KaffeemaschinenArten)))
            {
                listBoxKaffeemaschinen.Items.Add(item);
            }
        }

        private void listBoxKaffeemaschinen_SelectedValueChanged(object sender, EventArgs e)
        {
            if (listBoxKaffeemaschinen.SelectedItem == null)
                return;

            KaffeemaschinenArten ausgewählteMaschine = (KaffeemaschinenArten)listBoxKaffeemaschinen.SelectedItem;

            switch (ausgewählteMaschine)
            {
                case KaffeemaschinenArten.Filtermaschine:
                    _ausgewählteMaschine = _filterMaschine;
                    break;
                case KaffeemaschinenArten.PadMaschine:
                    _ausgewählteMaschine = _padMaschine;
                    break;
                case KaffeemaschinenArten.Vollautomat:
                    _ausgewählteMaschine = _vollautomat;
                    break;
                default:
                    break;
            }

            labelMaschinenbeschreibung.Text = _ausgewählteMaschine.ToString();
        }

        public void FülleEtwasEin(TextBox textbox, string errorpart, Action<float> action)
        {
            if (_ausgewählteMaschine == null)
            {
                return;
            }

            float menge = 0;

            try
            {
                menge = float.Parse(textbox.Text);
            }
            catch (FormatException)
            {
                FehlerIstAufgetreten($"Die {errorpart} ist keine gültige Zahl!");
                return;
            }
            catch (OverflowException)
            {
                FehlerIstAufgetreten($"Die {errorpart} ist zu groß!");
                return;
            }
            catch (Exception exp)
            {
                FehlerIstAufgetreten(exp.Message);
                return;
            }

            //Delegate aufrufen
            action(menge);

            labelMaschinenbeschreibung.Text = _ausgewählteMaschine.ToString();
        }

        #region Button_EventHandler
        private void wasser_button_click(object sender, EventArgs e)
        {
            FülleEtwasEin(textBoxWasser, "Wasserstand", FülleWasserEin);
        }

        private void Kaffee_button_click(object sender, EventArgs e)
        {
            if (_ausgewählteMaschine is Filtermaschine)
            {
                FülleEtwasEin(textBoxKaffee, "Kaffeemenge", FülleKaffeEin);
            }
            else
            {
                FehlerIstAufgetreten("Das ist keine Filtermaschine!");
            }
        }

        private void button_milch_click(object sender, EventArgs e)
        {
            if (_ausgewählteMaschine is Vollautomat)
            {
                FülleEtwasEin(textBoxMilch, "Milchmenge", FülleMilchEin);
            }
            else
            {
                FehlerIstAufgetreten("Das ist keine Milchmaschine!");
            }
        }
        private void button_pad_click(object sender, EventArgs e)
        {
            if (_ausgewählteMaschine is PadMaschine)
            {
                ((PadMaschine)_ausgewählteMaschine).PadEingelegt = true;
                labelMaschinenbeschreibung.Text = _ausgewählteMaschine.ToString();
            }
            else
            {
                FehlerIstAufgetreten("Das ist keine Padmaschine!");
            }
        }
        #endregion

        #region Hilfsmethoden fürs Delegate
        private void FülleWasserEin(float menge)
        {
            _ausgewählteMaschine.FülleWasserEin(menge);
        }

        private void FülleKaffeEin(float menge)
        {
            ((Filtermaschine)_ausgewählteMaschine).FülleKaffeEin(menge);
        }

        private void FülleMilchEin(float menge)
        {
            ((Vollautomat)_ausgewählteMaschine).FülleMilchEin(menge);
        }
        #endregion

        private void zubereiten_button_click(object sender, EventArgs e)
        {
            if(_ausgewählteMaschine == null)
            {
                FehlerIstAufgetreten("Es wurde keine Maschine ausgewählt!");
                return;
            }

            //Wurde die richtige Maschine ausgewählt?
            if (_aktuelleBestellung.Kaffeeart != _ausgewählteMaschine.Produziert)
            {
                FehlerIstAufgetreten("Falsche Maschine für diese Bestellung!");
                return;
            }

            #region Variante mit switch-case
            //switch (_aktuelleBestellung.Kaffeeart)
            //{
            //    case Bestellung.Kaffeearten.Filterkaffee:
            //        if(_ausgewählteMaschine.GetType() != typeof(Filtermaschine))
            //        {
            //            FehlerIstAufgetreten("Du brauchst eine Filtermaschine!");
            //            return;
            //        }
            //        break;
            //    case Bestellung.Kaffeearten.Cappuccino:
            //        if (_ausgewählteMaschine.GetType() != typeof(Vollautomat))
            //        {
            //            FehlerIstAufgetreten("Du brauchst eine Filtermaschine!");
            //            return;
            //        }
            //        break;
            //    case Bestellung.Kaffeearten.Espresso:
            //        if (_ausgewählteMaschine.GetType() != typeof(PadMaschine))
            //        {
            //            FehlerIstAufgetreten("Du brauchst eine Filtermaschine!");
            //            return;
            //        }
            //        break;
            //    default:
            //        break;
            //}
            #endregion

            bool hatGeklappt = _ausgewählteMaschine.BereiteZu(_aktuelleBestellung.Menge);
            if (hatGeklappt == false)
            {
                return;
            }

            //Nächste Bestellung anzeigen
            GeneriereNeueBestellung();

            labelMaschinenbeschreibung.Text = _ausgewählteMaschine.ToString();
        }

        #region Auf Enter-Druck in TextBox reagieren
        private void textBoxWasser_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TextBox box = (TextBox)sender;
                switch (box.Tag)
                {
                    case "Wasser":
                        wasser_button_click(null, null);
                        break;
                    case "Kaffee":
                        Kaffee_button_click(null, null);
                        break;
                    case "Milch":
                        button_milch_click(null, null);
                        break;
                }
            }
        }
        #endregion

    }
}

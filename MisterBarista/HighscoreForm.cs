using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MisterBarista
{
    public partial class HighscoreForm : Form
    {
        public int Score { get; private set; }

        public HighscoreForm(int score)
        {
            InitializeComponent();
            Score = score;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(textBoxName.Text))
            {
                MessageBox.Show("Bitte gib einen Namen ein!");
                return;
            }

            HighscoreEintrag neuerEintrag = new HighscoreEintrag(textBoxName.Text, Score);
            HighscoreManager.HighscoreListe.Add(neuerEintrag);
            //Speichern
            HighscoreManager.Speichern();
            this.Close();
        }
    }
}

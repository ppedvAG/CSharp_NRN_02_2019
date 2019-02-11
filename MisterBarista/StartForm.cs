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
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
            dataGridViewHighscore.DataSource = HighscoreManager.HighscoreListe;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.ShowDialog();
            dataGridViewHighscore.DataSource = HighscoreManager.HighscoreListe;
        }
    }
}

namespace MisterBarista
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.listBoxKaffeemaschinen = new System.Windows.Forms.ListBox();
            this.labelMaschinenbeschreibung = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.textBoxWasser = new System.Windows.Forms.TextBox();
            this.textBoxKaffee = new System.Windows.Forms.TextBox();
            this.textBoxMilch = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.labelBedienungsfehler = new System.Windows.Forms.Label();
            this.labelBestellung = new System.Windows.Forms.Label();
            this.labelScore = new System.Windows.Forms.Label();
            this.timerCountdown = new System.Windows.Forms.Timer(this.components);
            this.labelCountdown = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxKaffeemaschinen
            // 
            this.listBoxKaffeemaschinen.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxKaffeemaschinen.FormattingEnabled = true;
            this.listBoxKaffeemaschinen.ItemHeight = 32;
            this.listBoxKaffeemaschinen.Location = new System.Drawing.Point(22, 23);
            this.listBoxKaffeemaschinen.Name = "listBoxKaffeemaschinen";
            this.listBoxKaffeemaschinen.Size = new System.Drawing.Size(325, 196);
            this.listBoxKaffeemaschinen.TabIndex = 0;
            this.listBoxKaffeemaschinen.SelectedValueChanged += new System.EventHandler(this.listBoxKaffeemaschinen_SelectedValueChanged);
            // 
            // labelMaschinenbeschreibung
            // 
            this.labelMaschinenbeschreibung.AutoSize = true;
            this.labelMaschinenbeschreibung.Font = new System.Drawing.Font("Cooper Black", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMaschinenbeschreibung.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.labelMaschinenbeschreibung.Location = new System.Drawing.Point(48, 277);
            this.labelMaschinenbeschreibung.Name = "labelMaschinenbeschreibung";
            this.labelMaschinenbeschreibung.Size = new System.Drawing.Size(641, 46);
            this.labelMaschinenbeschreibung.TabIndex = 1;
            this.labelMaschinenbeschreibung.Text = "Kaffeemaschinenbeschreibung";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(261, 39);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(219, 83);
            this.button1.TabIndex = 2;
            this.button1.Text = "Wasser einfüllen";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.wasser_button_click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(261, 135);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(219, 69);
            this.button2.TabIndex = 3;
            this.button2.Text = "Kaffee einfüllen";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Kaffee_button_click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(261, 223);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(219, 69);
            this.button3.TabIndex = 4;
            this.button3.Text = "Milch einfüllen";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button_milch_click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(261, 325);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(219, 69);
            this.button4.TabIndex = 5;
            this.button4.Text = "Pad einlegen";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button_pad_click);
            // 
            // textBoxWasser
            // 
            this.textBoxWasser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxWasser.Location = new System.Drawing.Point(40, 63);
            this.textBoxWasser.Name = "textBoxWasser";
            this.textBoxWasser.Size = new System.Drawing.Size(185, 35);
            this.textBoxWasser.TabIndex = 6;
            this.textBoxWasser.Tag = "Wasser";
            this.textBoxWasser.Text = "0,1";
            this.textBoxWasser.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxWasser_KeyUp);
            // 
            // textBoxKaffee
            // 
            this.textBoxKaffee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxKaffee.Location = new System.Drawing.Point(40, 150);
            this.textBoxKaffee.Name = "textBoxKaffee";
            this.textBoxKaffee.Size = new System.Drawing.Size(185, 35);
            this.textBoxKaffee.TabIndex = 7;
            this.textBoxKaffee.Tag = "Kaffee";
            this.textBoxKaffee.Text = "0,1";
            this.textBoxKaffee.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxWasser_KeyUp);
            // 
            // textBoxMilch
            // 
            this.textBoxMilch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMilch.Location = new System.Drawing.Point(40, 240);
            this.textBoxMilch.Name = "textBoxMilch";
            this.textBoxMilch.Size = new System.Drawing.Size(185, 35);
            this.textBoxMilch.TabIndex = 8;
            this.textBoxMilch.Tag = "Milch";
            this.textBoxMilch.Text = "0,1";
            this.textBoxMilch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxWasser_KeyUp);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Aqua;
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.textBoxMilch);
            this.panel1.Controls.Add(this.textBoxKaffee);
            this.panel1.Controls.Add(this.textBoxWasser);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(785, 208);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(496, 429);
            this.panel1.TabIndex = 9;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(20, 325);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(219, 69);
            this.button5.TabIndex = 9;
            this.button5.Text = "Bereite zu";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.zubereiten_button_click);
            // 
            // labelBedienungsfehler
            // 
            this.labelBedienungsfehler.AutoSize = true;
            this.labelBedienungsfehler.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBedienungsfehler.ForeColor = System.Drawing.Color.Red;
            this.labelBedienungsfehler.Location = new System.Drawing.Point(779, 666);
            this.labelBedienungsfehler.Name = "labelBedienungsfehler";
            this.labelBedienungsfehler.Size = new System.Drawing.Size(197, 32);
            this.labelBedienungsfehler.TabIndex = 10;
            this.labelBedienungsfehler.Text = "Fehleranzeige";
            // 
            // labelBestellung
            // 
            this.labelBestellung.AutoSize = true;
            this.labelBestellung.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBestellung.ForeColor = System.Drawing.Color.Black;
            this.labelBestellung.Location = new System.Drawing.Point(452, 41);
            this.labelBestellung.Name = "labelBestellung";
            this.labelBestellung.Size = new System.Drawing.Size(158, 32);
            this.labelBestellung.TabIndex = 11;
            this.labelBestellung.Text = "Bestellung:";
            // 
            // labelScore
            // 
            this.labelScore.AutoSize = true;
            this.labelScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelScore.ForeColor = System.Drawing.Color.Black;
            this.labelScore.Location = new System.Drawing.Point(452, 90);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(97, 32);
            this.labelScore.TabIndex = 12;
            this.labelScore.Text = "Score:";
            // 
            // timerCountdown
            // 
            this.timerCountdown.Enabled = true;
            this.timerCountdown.Interval = 1000;
            this.timerCountdown.Tick += new System.EventHandler(this.timerCountdown_Tick);
            // 
            // labelCountdown
            // 
            this.labelCountdown.AutoSize = true;
            this.labelCountdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCountdown.ForeColor = System.Drawing.Color.Black;
            this.labelCountdown.Location = new System.Drawing.Point(452, 142);
            this.labelCountdown.Name = "labelCountdown";
            this.labelCountdown.Size = new System.Drawing.Size(167, 32);
            this.labelCountdown.TabIndex = 14;
            this.labelCountdown.Text = "Countdown:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(1286, 707);
            this.Controls.Add(this.labelCountdown);
            this.Controls.Add(this.labelScore);
            this.Controls.Add(this.labelBestellung);
            this.Controls.Add(this.labelBedienungsfehler);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelMaschinenbeschreibung);
            this.Controls.Add(this.listBoxKaffeemaschinen);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Formular_Wurde_Geladen);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxKaffeemaschinen;
        private System.Windows.Forms.Label labelMaschinenbeschreibung;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBoxWasser;
        private System.Windows.Forms.TextBox textBoxKaffee;
        private System.Windows.Forms.TextBox textBoxMilch;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label labelBedienungsfehler;
        private System.Windows.Forms.Label labelBestellung;
        private System.Windows.Forms.Label labelScore;
        private System.Windows.Forms.Timer timerCountdown;
        private System.Windows.Forms.Label labelCountdown;
    }
}


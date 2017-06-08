namespace UI
{
    partial class Transakcje_Cykliczne
    {
        /// <summary> 
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod wygenerowany przez Projektanta składników

        /// <summary> 
        /// Wymagana metoda obsługi projektanta — nie należy modyfikować 
        /// zawartość tej metody z edytorem kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Transakcje_Cykliczne));
            this.bt_Dodaj = new System.Windows.Forms.Button();
            this.cb_przelewy = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lb_ZRachunku = new System.Windows.Forms.Label();
            this.lb_NaRachunek = new System.Windows.Forms.Label();
            this.lb_Kwota = new System.Windows.Forms.Label();
            this.lb_Tytuł = new System.Windows.Forms.Label();
            this.lb_Czestotliwosc = new System.Windows.Forms.Label();
            this.lb_Dpw = new System.Windows.Forms.Label();
            this.lb_Dow = new System.Windows.Forms.Label();
            this.tb_NaRachunek = new System.Windows.Forms.TextBox();
            this.tb_Kwota = new System.Windows.Forms.TextBox();
            this.tb_Tytul = new System.Windows.Forms.TextBox();
            this.tb_Czestotliwosc = new System.Windows.Forms.TextBox();
            this.tb_dpw = new System.Windows.Forms.TextBox();
            this.tb_dow = new System.Windows.Forms.TextBox();
            this.bt_Anuluj = new System.Windows.Forms.Button();
            this.cb_ZRachunku = new System.Windows.Forms.ComboBox();
            this.bt_wyslij = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bt_Dodaj
            // 
            this.bt_Dodaj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.bt_Dodaj.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_Dodaj.BackgroundImage")));
            this.bt_Dodaj.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bt_Dodaj.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_Dodaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bt_Dodaj.ForeColor = System.Drawing.Color.Snow;
            this.bt_Dodaj.Location = new System.Drawing.Point(556, 7);
            this.bt_Dodaj.Margin = new System.Windows.Forms.Padding(2);
            this.bt_Dodaj.Name = "bt_Dodaj";
            this.bt_Dodaj.Size = new System.Drawing.Size(68, 28);
            this.bt_Dodaj.TabIndex = 6;
            this.bt_Dodaj.Text = "Dodaj przelew";
            this.bt_Dodaj.UseVisualStyleBackColor = false;
            this.bt_Dodaj.Click += new System.EventHandler(this.button1_Click);
            // 
            // cb_przelewy
            // 
            this.cb_przelewy.FormattingEnabled = true;
            this.cb_przelewy.Location = new System.Drawing.Point(3, 6);
            this.cb_przelewy.Name = "cb_przelewy";
            this.cb_przelewy.Size = new System.Drawing.Size(548, 21);
            this.cb_przelewy.TabIndex = 7;
            this.cb_przelewy.SelectedIndexChanged += new System.EventHandler(this.cb_przelewy_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(119, 46);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 20);
            this.label5.TabIndex = 19;
            this.label5.Text = "Z rachunku:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(109, 79);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 20);
            this.label1.TabIndex = 20;
            this.label1.Text = "Na rachunek:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(155, 109);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 21;
            this.label2.Text = "Kwota:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(165, 139);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 20);
            this.label3.TabIndex = 22;
            this.label3.Text = "Tytuł:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(2, 202);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(210, 20);
            this.label4.TabIndex = 23;
            this.label4.Text = "Data pierwszego wykonania:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label6
            // 
            this.label6.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(102, 170);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 20);
            this.label6.TabIndex = 24;
            this.label6.Text = "Czestotliwość:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(7, 232);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(205, 20);
            this.label7.TabIndex = 25;
            this.label7.Text = "Data ostatniego wykonania:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // lb_ZRachunku
            // 
            this.lb_ZRachunku.AutoSize = true;
            this.lb_ZRachunku.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lb_ZRachunku.ForeColor = System.Drawing.SystemColors.Control;
            this.lb_ZRachunku.Location = new System.Drawing.Point(216, 46);
            this.lb_ZRachunku.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_ZRachunku.Name = "lb_ZRachunku";
            this.lb_ZRachunku.Size = new System.Drawing.Size(14, 20);
            this.lb_ZRachunku.TabIndex = 26;
            this.lb_ZRachunku.Text = "-";
            // 
            // lb_NaRachunek
            // 
            this.lb_NaRachunek.AutoSize = true;
            this.lb_NaRachunek.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lb_NaRachunek.ForeColor = System.Drawing.SystemColors.Control;
            this.lb_NaRachunek.Location = new System.Drawing.Point(216, 79);
            this.lb_NaRachunek.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_NaRachunek.Name = "lb_NaRachunek";
            this.lb_NaRachunek.Size = new System.Drawing.Size(14, 20);
            this.lb_NaRachunek.TabIndex = 27;
            this.lb_NaRachunek.Text = "-";
            // 
            // lb_Kwota
            // 
            this.lb_Kwota.AutoSize = true;
            this.lb_Kwota.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lb_Kwota.ForeColor = System.Drawing.SystemColors.Control;
            this.lb_Kwota.Location = new System.Drawing.Point(216, 109);
            this.lb_Kwota.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_Kwota.Name = "lb_Kwota";
            this.lb_Kwota.Size = new System.Drawing.Size(14, 20);
            this.lb_Kwota.TabIndex = 28;
            this.lb_Kwota.Text = "-";
            // 
            // lb_Tytuł
            // 
            this.lb_Tytuł.AutoSize = true;
            this.lb_Tytuł.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lb_Tytuł.ForeColor = System.Drawing.SystemColors.Control;
            this.lb_Tytuł.Location = new System.Drawing.Point(216, 139);
            this.lb_Tytuł.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_Tytuł.Name = "lb_Tytuł";
            this.lb_Tytuł.Size = new System.Drawing.Size(14, 20);
            this.lb_Tytuł.TabIndex = 29;
            this.lb_Tytuł.Text = "-";
            // 
            // lb_Czestotliwosc
            // 
            this.lb_Czestotliwosc.AutoSize = true;
            this.lb_Czestotliwosc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lb_Czestotliwosc.ForeColor = System.Drawing.SystemColors.Control;
            this.lb_Czestotliwosc.Location = new System.Drawing.Point(216, 170);
            this.lb_Czestotliwosc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_Czestotliwosc.Name = "lb_Czestotliwosc";
            this.lb_Czestotliwosc.Size = new System.Drawing.Size(14, 20);
            this.lb_Czestotliwosc.TabIndex = 30;
            this.lb_Czestotliwosc.Text = "-";
            // 
            // lb_Dpw
            // 
            this.lb_Dpw.AutoSize = true;
            this.lb_Dpw.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lb_Dpw.ForeColor = System.Drawing.SystemColors.Control;
            this.lb_Dpw.Location = new System.Drawing.Point(216, 202);
            this.lb_Dpw.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_Dpw.Name = "lb_Dpw";
            this.lb_Dpw.Size = new System.Drawing.Size(14, 20);
            this.lb_Dpw.TabIndex = 31;
            this.lb_Dpw.Text = "-";
            // 
            // lb_Dow
            // 
            this.lb_Dow.AutoSize = true;
            this.lb_Dow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lb_Dow.ForeColor = System.Drawing.SystemColors.Control;
            this.lb_Dow.Location = new System.Drawing.Point(216, 232);
            this.lb_Dow.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_Dow.Name = "lb_Dow";
            this.lb_Dow.Size = new System.Drawing.Size(14, 20);
            this.lb_Dow.TabIndex = 32;
            this.lb_Dow.Text = "-";
            // 
            // tb_NaRachunek
            // 
            this.tb_NaRachunek.Location = new System.Drawing.Point(220, 79);
            this.tb_NaRachunek.Name = "tb_NaRachunek";
            this.tb_NaRachunek.Size = new System.Drawing.Size(331, 20);
            this.tb_NaRachunek.TabIndex = 34;
            this.tb_NaRachunek.Visible = false;
            // 
            // tb_Kwota
            // 
            this.tb_Kwota.Location = new System.Drawing.Point(220, 111);
            this.tb_Kwota.Name = "tb_Kwota";
            this.tb_Kwota.Size = new System.Drawing.Size(331, 20);
            this.tb_Kwota.TabIndex = 35;
            this.tb_Kwota.Visible = false;
            // 
            // tb_Tytul
            // 
            this.tb_Tytul.Location = new System.Drawing.Point(220, 141);
            this.tb_Tytul.Name = "tb_Tytul";
            this.tb_Tytul.Size = new System.Drawing.Size(331, 20);
            this.tb_Tytul.TabIndex = 36;
            this.tb_Tytul.Visible = false;
            // 
            // tb_Czestotliwosc
            // 
            this.tb_Czestotliwosc.Location = new System.Drawing.Point(220, 172);
            this.tb_Czestotliwosc.Name = "tb_Czestotliwosc";
            this.tb_Czestotliwosc.Size = new System.Drawing.Size(331, 20);
            this.tb_Czestotliwosc.TabIndex = 37;
            this.tb_Czestotliwosc.Visible = false;
            // 
            // tb_dpw
            // 
            this.tb_dpw.Location = new System.Drawing.Point(220, 204);
            this.tb_dpw.Name = "tb_dpw";
            this.tb_dpw.Size = new System.Drawing.Size(331, 20);
            this.tb_dpw.TabIndex = 38;
            this.tb_dpw.Visible = false;
            // 
            // tb_dow
            // 
            this.tb_dow.Location = new System.Drawing.Point(220, 234);
            this.tb_dow.Name = "tb_dow";
            this.tb_dow.Size = new System.Drawing.Size(331, 20);
            this.tb_dow.TabIndex = 39;
            this.tb_dow.Visible = false;
            // 
            // bt_Anuluj
            // 
            this.bt_Anuluj.BackColor = System.Drawing.Color.Maroon;
            this.bt_Anuluj.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_Anuluj.BackgroundImage")));
            this.bt_Anuluj.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bt_Anuluj.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_Anuluj.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bt_Anuluj.ForeColor = System.Drawing.Color.Snow;
            this.bt_Anuluj.Location = new System.Drawing.Point(556, 39);
            this.bt_Anuluj.Margin = new System.Windows.Forms.Padding(2);
            this.bt_Anuluj.Name = "bt_Anuluj";
            this.bt_Anuluj.Size = new System.Drawing.Size(68, 28);
            this.bt_Anuluj.TabIndex = 40;
            this.bt_Anuluj.Text = "Anuluj";
            this.bt_Anuluj.UseVisualStyleBackColor = false;
            this.bt_Anuluj.Visible = false;
            this.bt_Anuluj.Click += new System.EventHandler(this.bt_Anuluj_Click);
            // 
            // cb_ZRachunku
            // 
            this.cb_ZRachunku.FormattingEnabled = true;
            this.cb_ZRachunku.Location = new System.Drawing.Point(220, 48);
            this.cb_ZRachunku.Name = "cb_ZRachunku";
            this.cb_ZRachunku.Size = new System.Drawing.Size(331, 21);
            this.cb_ZRachunku.TabIndex = 41;
            this.cb_ZRachunku.Visible = false;
            // 
            // bt_wyslij
            // 
            this.bt_wyslij.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.bt_wyslij.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_wyslij.BackgroundImage")));
            this.bt_wyslij.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bt_wyslij.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_wyslij.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bt_wyslij.ForeColor = System.Drawing.Color.Snow;
            this.bt_wyslij.Location = new System.Drawing.Point(556, 7);
            this.bt_wyslij.Margin = new System.Windows.Forms.Padding(2);
            this.bt_wyslij.Name = "bt_wyslij";
            this.bt_wyslij.Size = new System.Drawing.Size(68, 28);
            this.bt_wyslij.TabIndex = 42;
            this.bt_wyslij.Text = "Wyślij";
            this.bt_wyslij.UseVisualStyleBackColor = false;
            this.bt_wyslij.Visible = false;
            this.bt_wyslij.Click += new System.EventHandler(this.bt_wyslij_Click);
            // 
            // Transakcje_Cykliczne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.Controls.Add(this.bt_wyslij);
            this.Controls.Add(this.cb_ZRachunku);
            this.Controls.Add(this.bt_Anuluj);
            this.Controls.Add(this.tb_dow);
            this.Controls.Add(this.tb_dpw);
            this.Controls.Add(this.tb_Czestotliwosc);
            this.Controls.Add(this.tb_Tytul);
            this.Controls.Add(this.tb_Kwota);
            this.Controls.Add(this.tb_NaRachunek);
            this.Controls.Add(this.lb_Dow);
            this.Controls.Add(this.lb_Dpw);
            this.Controls.Add(this.lb_Czestotliwosc);
            this.Controls.Add(this.lb_Tytuł);
            this.Controls.Add(this.lb_Kwota);
            this.Controls.Add(this.lb_NaRachunek);
            this.Controls.Add(this.lb_ZRachunku);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cb_przelewy);
            this.Controls.Add(this.bt_Dodaj);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Transakcje_Cykliczne";
            this.Size = new System.Drawing.Size(626, 396);
            this.Load += new System.EventHandler(this.Transakcje_Cykliczne_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_Dodaj;
        private System.Windows.Forms.ComboBox cb_przelewy;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lb_ZRachunku;
        private System.Windows.Forms.Label lb_NaRachunek;
        private System.Windows.Forms.Label lb_Kwota;
        private System.Windows.Forms.Label lb_Tytuł;
        private System.Windows.Forms.Label lb_Czestotliwosc;
        private System.Windows.Forms.Label lb_Dpw;
        private System.Windows.Forms.Label lb_Dow;
        private System.Windows.Forms.TextBox tb_NaRachunek;
        private System.Windows.Forms.TextBox tb_Kwota;
        private System.Windows.Forms.TextBox tb_Tytul;
        private System.Windows.Forms.TextBox tb_Czestotliwosc;
        private System.Windows.Forms.TextBox tb_dpw;
        private System.Windows.Forms.TextBox tb_dow;
        private System.Windows.Forms.Button bt_Anuluj;
        private System.Windows.Forms.ComboBox cb_ZRachunku;
        private System.Windows.Forms.Button bt_wyslij;
    }
}

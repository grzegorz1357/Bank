namespace UI
{
    partial class Transakcje_Odbiorcy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Transakcje_Odbiorcy));
            this.cb_odbiorcy = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_Nazwa = new System.Windows.Forms.Label();
            this.lb_Adres = new System.Windows.Forms.Label();
            this.lb_NRachunku = new System.Windows.Forms.Label();
            this.tb_Nazwa = new System.Windows.Forms.TextBox();
            this.tb_Adres = new System.Windows.Forms.TextBox();
            this.tb_NumerRachunku = new System.Windows.Forms.TextBox();
            this.bt_DodajOdbiorce = new System.Windows.Forms.Button();
            this.bt_Anuluj = new System.Windows.Forms.Button();
            this.bt_wyslij = new System.Windows.Forms.Button();
            this.bt_przelew = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cb_odbiorcy
            // 
            this.cb_odbiorcy.FormattingEnabled = true;
            this.cb_odbiorcy.Location = new System.Drawing.Point(3, 11);
            this.cb_odbiorcy.Name = "cb_odbiorcy";
            this.cb_odbiorcy.Size = new System.Drawing.Size(532, 21);
            this.cb_odbiorcy.TabIndex = 1;
            this.cb_odbiorcy.SelectedIndexChanged += new System.EventHandler(this.cb_odbiorcy_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(112, 45);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 20);
            this.label5.TabIndex = 20;
            this.label5.Text = "Nazwa:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(120, 71);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 21;
            this.label1.Text = "Adres:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(45, 97);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 20);
            this.label2.TabIndex = 22;
            this.label2.Text = "numer rachunku:";
            // 
            // lb_Nazwa
            // 
            this.lb_Nazwa.AutoSize = true;
            this.lb_Nazwa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lb_Nazwa.ForeColor = System.Drawing.SystemColors.Control;
            this.lb_Nazwa.Location = new System.Drawing.Point(177, 45);
            this.lb_Nazwa.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_Nazwa.Name = "lb_Nazwa";
            this.lb_Nazwa.Size = new System.Drawing.Size(14, 20);
            this.lb_Nazwa.TabIndex = 27;
            this.lb_Nazwa.Text = "-";
            // 
            // lb_Adres
            // 
            this.lb_Adres.AutoSize = true;
            this.lb_Adres.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lb_Adres.ForeColor = System.Drawing.SystemColors.Control;
            this.lb_Adres.Location = new System.Drawing.Point(177, 71);
            this.lb_Adres.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_Adres.Name = "lb_Adres";
            this.lb_Adres.Size = new System.Drawing.Size(14, 20);
            this.lb_Adres.TabIndex = 28;
            this.lb_Adres.Text = "-";
            // 
            // lb_NRachunku
            // 
            this.lb_NRachunku.AutoSize = true;
            this.lb_NRachunku.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lb_NRachunku.ForeColor = System.Drawing.SystemColors.Control;
            this.lb_NRachunku.Location = new System.Drawing.Point(177, 97);
            this.lb_NRachunku.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_NRachunku.Name = "lb_NRachunku";
            this.lb_NRachunku.Size = new System.Drawing.Size(14, 20);
            this.lb_NRachunku.TabIndex = 29;
            this.lb_NRachunku.Text = "-";
            // 
            // tb_Nazwa
            // 
            this.tb_Nazwa.Location = new System.Drawing.Point(181, 45);
            this.tb_Nazwa.Name = "tb_Nazwa";
            this.tb_Nazwa.Size = new System.Drawing.Size(354, 20);
            this.tb_Nazwa.TabIndex = 43;
            this.tb_Nazwa.Visible = false;
            // 
            // tb_Adres
            // 
            this.tb_Adres.Location = new System.Drawing.Point(181, 71);
            this.tb_Adres.Name = "tb_Adres";
            this.tb_Adres.Size = new System.Drawing.Size(354, 20);
            this.tb_Adres.TabIndex = 44;
            this.tb_Adres.Visible = false;
            // 
            // tb_NumerRachunku
            // 
            this.tb_NumerRachunku.Location = new System.Drawing.Point(181, 97);
            this.tb_NumerRachunku.Name = "tb_NumerRachunku";
            this.tb_NumerRachunku.Size = new System.Drawing.Size(354, 20);
            this.tb_NumerRachunku.TabIndex = 45;
            this.tb_NumerRachunku.Visible = false;
            // 
            // bt_DodajOdbiorce
            // 
            this.bt_DodajOdbiorce.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.bt_DodajOdbiorce.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_DodajOdbiorce.BackgroundImage")));
            this.bt_DodajOdbiorce.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bt_DodajOdbiorce.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_DodajOdbiorce.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.bt_DodajOdbiorce.ForeColor = System.Drawing.Color.Snow;
            this.bt_DodajOdbiorce.Location = new System.Drawing.Point(554, 11);
            this.bt_DodajOdbiorce.Margin = new System.Windows.Forms.Padding(2);
            this.bt_DodajOdbiorce.Name = "bt_DodajOdbiorce";
            this.bt_DodajOdbiorce.Size = new System.Drawing.Size(70, 25);
            this.bt_DodajOdbiorce.TabIndex = 46;
            this.bt_DodajOdbiorce.Text = "Dodaj Odbiorce";
            this.bt_DodajOdbiorce.UseVisualStyleBackColor = false;
            this.bt_DodajOdbiorce.Click += new System.EventHandler(this.bt_DodajOdbiorce_Click);
            // 
            // bt_Anuluj
            // 
            this.bt_Anuluj.BackColor = System.Drawing.Color.Maroon;
            this.bt_Anuluj.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_Anuluj.BackgroundImage")));
            this.bt_Anuluj.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bt_Anuluj.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_Anuluj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.bt_Anuluj.ForeColor = System.Drawing.Color.Snow;
            this.bt_Anuluj.Location = new System.Drawing.Point(554, 40);
            this.bt_Anuluj.Margin = new System.Windows.Forms.Padding(2);
            this.bt_Anuluj.Name = "bt_Anuluj";
            this.bt_Anuluj.Size = new System.Drawing.Size(70, 25);
            this.bt_Anuluj.TabIndex = 47;
            this.bt_Anuluj.Text = "Anuluj";
            this.bt_Anuluj.UseVisualStyleBackColor = false;
            this.bt_Anuluj.Visible = false;
            this.bt_Anuluj.Click += new System.EventHandler(this.bt_Anuluj_Click);
            // 
            // bt_wyslij
            // 
            this.bt_wyslij.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.bt_wyslij.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_wyslij.BackgroundImage")));
            this.bt_wyslij.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bt_wyslij.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_wyslij.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.bt_wyslij.ForeColor = System.Drawing.Color.Snow;
            this.bt_wyslij.Location = new System.Drawing.Point(554, 11);
            this.bt_wyslij.Margin = new System.Windows.Forms.Padding(2);
            this.bt_wyslij.Name = "bt_wyslij";
            this.bt_wyslij.Size = new System.Drawing.Size(70, 25);
            this.bt_wyslij.TabIndex = 48;
            this.bt_wyslij.Text = "Wyślij";
            this.bt_wyslij.UseVisualStyleBackColor = false;
            this.bt_wyslij.Visible = false;
            this.bt_wyslij.Click += new System.EventHandler(this.bt_wyslij_Click);
            // 
            // bt_przelew
            // 
            this.bt_przelew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.bt_przelew.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_przelew.BackgroundImage")));
            this.bt_przelew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bt_przelew.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_przelew.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.bt_przelew.ForeColor = System.Drawing.Color.Snow;
            this.bt_przelew.Location = new System.Drawing.Point(436, 122);
            this.bt_przelew.Margin = new System.Windows.Forms.Padding(2);
            this.bt_przelew.Name = "bt_przelew";
            this.bt_przelew.Size = new System.Drawing.Size(99, 53);
            this.bt_przelew.TabIndex = 49;
            this.bt_przelew.Text = "Wykonaj Przelew";
            this.bt_przelew.UseVisualStyleBackColor = false;
            this.bt_przelew.Click += new System.EventHandler(this.bt_przelew_Click);
            // 
            // Transakcje_Odbiorcy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.Controls.Add(this.bt_przelew);
            this.Controls.Add(this.bt_wyslij);
            this.Controls.Add(this.bt_Anuluj);
            this.Controls.Add(this.bt_DodajOdbiorce);
            this.Controls.Add(this.tb_NumerRachunku);
            this.Controls.Add(this.tb_Adres);
            this.Controls.Add(this.tb_Nazwa);
            this.Controls.Add(this.lb_NRachunku);
            this.Controls.Add(this.lb_Adres);
            this.Controls.Add(this.lb_Nazwa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cb_odbiorcy);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Transakcje_Odbiorcy";
            this.Size = new System.Drawing.Size(626, 396);
            this.Load += new System.EventHandler(this.Transakcje_Odbiorcy_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cb_odbiorcy;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lb_Nazwa;
        private System.Windows.Forms.Label lb_Adres;
        private System.Windows.Forms.Label lb_NRachunku;
        private System.Windows.Forms.TextBox tb_Nazwa;
        private System.Windows.Forms.TextBox tb_Adres;
        private System.Windows.Forms.TextBox tb_NumerRachunku;
        private System.Windows.Forms.Button bt_DodajOdbiorce;
        private System.Windows.Forms.Button bt_Anuluj;
        private System.Windows.Forms.Button bt_wyslij;
        private System.Windows.Forms.Button bt_przelew;
    }
}

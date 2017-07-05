namespace UI
{
    partial class Rachunki_lista
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
            this.label5 = new System.Windows.Forms.Label();
            this.cb_rachunki = new System.Windows.Forms.ComboBox();
            this.dgv_rachunek = new System.Windows.Forms.DataGridView();
<<<<<<< HEAD
            this.label1 = new System.Windows.Forms.Label();
            this.lb_srodki = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
=======
>>>>>>> origin/master
            this.Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nadawca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Odbiorca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Opis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kwota = new System.Windows.Forms.DataGridViewTextBoxColumn();
<<<<<<< HEAD
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
=======
            this.label1 = new System.Windows.Forms.Label();
            this.lb_srodki = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
>>>>>>> origin/master
            ((System.ComponentModel.ISupportInitialize)(this.dgv_rachunek)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(15, 9);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Wybierz rachunek:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // cb_rachunki
            // 
            this.cb_rachunki.BackColor = System.Drawing.Color.DarkSlateGray;
            this.cb_rachunki.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_rachunki.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cb_rachunki.FormattingEnabled = true;
            this.cb_rachunki.Location = new System.Drawing.Point(19, 31);
            this.cb_rachunki.Margin = new System.Windows.Forms.Padding(2);
            this.cb_rachunki.Name = "cb_rachunki";
            this.cb_rachunki.Size = new System.Drawing.Size(409, 28);
            this.cb_rachunki.TabIndex = 12;
            this.cb_rachunki.SelectedIndexChanged += new System.EventHandler(this.cb_rachunki_SelectedIndexChanged);
            this.cb_rachunki.SelectionChangeCommitted += new System.EventHandler(this.cb_rachunki_SelectionChangeCommitted);
            // 
            // dgv_rachunek
            // 
            this.dgv_rachunek.BackgroundColor = System.Drawing.Color.DarkSlateGray;
            this.dgv_rachunek.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_rachunek.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Data,
            this.Nadawca,
            this.Odbiorca,
            this.Opis,
<<<<<<< HEAD
            this.Kwota,
            this.Status});
=======
            this.Kwota});
>>>>>>> origin/master
            this.dgv_rachunek.Location = new System.Drawing.Point(19, 107);
            this.dgv_rachunek.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_rachunek.Name = "dgv_rachunek";
            this.dgv_rachunek.RowTemplate.Height = 24;
            this.dgv_rachunek.Size = new System.Drawing.Size(585, 361);
            this.dgv_rachunek.TabIndex = 14;
<<<<<<< HEAD
            this.dgv_rachunek.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgv_rachunek_RowsAdded);
=======
            // 
            // Data
            // 
            this.Data.DataPropertyName = "Data";
            this.Data.HeaderText = "Data";
            this.Data.Name = "Data";
            this.Data.ReadOnly = true;
            this.Data.Width = 92;
            // 
            // OdNad
            // 
            this.OdNad.DataPropertyName = "OdNad";
            this.OdNad.HeaderText = "Odbiorca/Nadawca";
            this.OdNad.Name = "OdNad";
            this.OdNad.ReadOnly = true;
            this.OdNad.Width = 200;
            // 
            // Opis
            // 
            this.Opis.DataPropertyName = "Opis";
            this.Opis.HeaderText = "Opis";
            this.Opis.Name = "Opis";
            this.Opis.ReadOnly = true;
            this.Opis.Width = 150;
            // 
            // Kwota
            // 
            this.Kwota.DataPropertyName = "Kwota";
            this.Kwota.HeaderText = "Kwota";
            this.Kwota.Name = "Kwota";
            this.Kwota.ReadOnly = true;
>>>>>>> origin/master
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(15, 85);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Historia ostatnich operacji:";
            // 
            // lb_srodki
            // 
            this.lb_srodki.AutoSize = true;
            this.lb_srodki.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lb_srodki.ForeColor = System.Drawing.Color.Aquamarine;
            this.lb_srodki.Location = new System.Drawing.Point(469, 56);
            this.lb_srodki.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_srodki.Name = "lb_srodki";
            this.lb_srodki.Size = new System.Drawing.Size(0, 20);
            this.lb_srodki.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(451, 31);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "Dostępne fundusze:";
            // 
<<<<<<< HEAD
            // Data
            // 
            this.Data.DataPropertyName = "Data";
            this.Data.HeaderText = "Data";
            this.Data.Name = "Data";
            this.Data.ReadOnly = true;
            this.Data.Width = 92;
            // 
            // Nadawca
            // 
            this.Nadawca.DataPropertyName = "Nadawca";
            this.Nadawca.HeaderText = "Nadawca";
            this.Nadawca.Name = "Nadawca";
            this.Nadawca.Width = 180;
            // 
            // Odbiorca
            // 
            this.Odbiorca.DataPropertyName = "Odbiorca";
            this.Odbiorca.HeaderText = "Odbiorca";
            this.Odbiorca.Name = "Odbiorca";
            this.Odbiorca.ReadOnly = true;
            this.Odbiorca.Width = 180;
            // 
            // Opis
            // 
            this.Opis.DataPropertyName = "Opis";
            this.Opis.HeaderText = "Opis";
            this.Opis.Name = "Opis";
            this.Opis.ReadOnly = true;
            this.Opis.Width = 150;
            // 
            // Kwota
            // 
            this.Kwota.DataPropertyName = "Kwota";
            this.Kwota.HeaderText = "Kwota";
            this.Kwota.Name = "Kwota";
            this.Kwota.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.Width = 90;
            // 
=======
>>>>>>> origin/master
            // Rachunki_lista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.Controls.Add(this.lb_srodki);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_rachunek);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cb_rachunki);
            this.Name = "Rachunki_lista";
            this.Size = new System.Drawing.Size(626, 479);
            this.Load += new System.EventHandler(this.Rachunki_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_rachunek)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cb_rachunki;
        private System.Windows.Forms.DataGridView dgv_rachunek;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_srodki;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nadawca;
        private System.Windows.Forms.DataGridViewTextBoxColumn Odbiorca;
        private System.Windows.Forms.DataGridViewTextBoxColumn Opis;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kwota;
<<<<<<< HEAD
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
=======
>>>>>>> origin/master
    }
}

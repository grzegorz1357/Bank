namespace UI
{
    partial class SG
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.cb_hidden = new System.Windows.Forms.ComboBox();
            this.lb_user = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lb_last_login_error = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lb_last_login = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvHistoria = new System.Windows.Forms.DataGridView();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nadawca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Odbiorca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Opis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kwota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistoria)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.cb_hidden);
            this.panel1.Controls.Add(this.lb_user);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.lb_last_login_error);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.lb_last_login);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dgvHistoria);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(626, 479);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(174, 121);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(284, 20);
            this.label6.TabIndex = 21;
            this.label6.Text = "HISTORIA OSTATNICH TRANSAKCJI";
            // 
            // cb_hidden
            // 
            this.cb_hidden.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.cb_hidden.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_hidden.FormattingEnabled = true;
            this.cb_hidden.Location = new System.Drawing.Point(445, 73);
            this.cb_hidden.Name = "cb_hidden";
            this.cb_hidden.Size = new System.Drawing.Size(121, 21);
            this.cb_hidden.TabIndex = 20;
            this.cb_hidden.Visible = false;
            this.cb_hidden.SelectedIndexChanged += new System.EventHandler(this.cb_hidden_SelectedIndexChanged);
            // 
            // lb_user
            // 
            this.lb_user.AutoSize = true;
            this.lb_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lb_user.ForeColor = System.Drawing.Color.Chartreuse;
            this.lb_user.Location = new System.Drawing.Point(163, 13);
            this.lb_user.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_user.Name = "lb_user";
            this.lb_user.Size = new System.Drawing.Size(72, 20);
            this.lb_user.TabIndex = 19;
            this.lb_user.Text = "get_user";
            this.lb_user.Click += new System.EventHandler(this.lb_user_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(17, 13);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 20);
            this.label5.TabIndex = 18;
            this.label5.Text = "Zalogowany jako:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // lb_last_login_error
            // 
            this.lb_last_login_error.AutoSize = true;
            this.lb_last_login_error.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lb_last_login_error.ForeColor = System.Drawing.Color.Salmon;
            this.lb_last_login_error.Location = new System.Drawing.Point(295, 74);
            this.lb_last_login_error.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_last_login_error.Name = "lb_last_login_error";
            this.lb_last_login_error.Size = new System.Drawing.Size(83, 20);
            this.lb_last_login_error.TabIndex = 17;
            this.lb_last_login_error.Text = "data_czas";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(17, 74);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(274, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "Czas ostatniego błędnego logowania:";
            // 
            // lb_last_login
            // 
            this.lb_last_login.AutoSize = true;
            this.lb_last_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lb_last_login.ForeColor = System.Drawing.Color.Chartreuse;
            this.lb_last_login.Location = new System.Drawing.Point(295, 48);
            this.lb_last_login.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_last_login.Name = "lb_last_login";
            this.lb_last_login.Size = new System.Drawing.Size(83, 20);
            this.lb_last_login.TabIndex = 15;
            this.lb_last_login.Text = "data_czas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(17, 48);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(203, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Czas ostatniego logowania:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.Aquamarine;
            this.label2.Location = new System.Drawing.Point(459, 38);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "1024,34 PLN";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(441, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Dostępne fundusze:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dgvHistoria
            // 
            this.dgvHistoria.BackgroundColor = System.Drawing.Color.DarkSlateGray;
            this.dgvHistoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHistoria.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Data,
            this.Nadawca,
            this.Odbiorca,
            this.Opis,
            this.Kwota,
            this.Status});
            this.dgvHistoria.Location = new System.Drawing.Point(21, 143);
            this.dgvHistoria.Margin = new System.Windows.Forms.Padding(2);
            this.dgvHistoria.Name = "dgvHistoria";
            this.dgvHistoria.RowTemplate.Height = 24;
            this.dgvHistoria.Size = new System.Drawing.Size(585, 324);
            this.dgvHistoria.TabIndex = 1;
            this.dgvHistoria.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHistoria_CellContentClick);
            this.dgvHistoria.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvHistoria_RowsAdded);
            // 
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
            this.Nadawca.FillWeight = 180F;
            this.Nadawca.HeaderText = "Nadawca";
            this.Nadawca.Name = "Nadawca";
            this.Nadawca.ReadOnly = true;
            this.Nadawca.Width = 180;
            // 
            // Odbiorca
            // 
            this.Odbiorca.DataPropertyName = "Odbiorca";
            this.Odbiorca.HeaderText = "Odbiorca";
            this.Odbiorca.Name = "Odbiorca";
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
            // SG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.Controls.Add(this.panel1);
            this.Name = "SG";
            this.Size = new System.Drawing.Size(626, 479);
            this.Load += new System.EventHandler(this.SG_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistoria)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvHistoria;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_last_login_error;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lb_last_login;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lb_user;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cb_hidden;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nadawca;
        private System.Windows.Forms.DataGridViewTextBoxColumn Odbiorca;
        private System.Windows.Forms.DataGridViewTextBoxColumn Opis;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kwota;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
    }
}

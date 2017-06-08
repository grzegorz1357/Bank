namespace UI
{
    partial class Lokaty
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lokaty));
            this.bt_ZalozLokate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bt_ZalozLokate
            // 
            this.bt_ZalozLokate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.bt_ZalozLokate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_ZalozLokate.BackgroundImage")));
            this.bt_ZalozLokate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bt_ZalozLokate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_ZalozLokate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bt_ZalozLokate.ForeColor = System.Drawing.Color.Snow;
            this.bt_ZalozLokate.Location = new System.Drawing.Point(513, 410);
            this.bt_ZalozLokate.Margin = new System.Windows.Forms.Padding(2);
            this.bt_ZalozLokate.Name = "bt_ZalozLokate";
            this.bt_ZalozLokate.Size = new System.Drawing.Size(105, 61);
            this.bt_ZalozLokate.TabIndex = 1;
            this.bt_ZalozLokate.Text = "Załóż lokatę";
            this.bt_ZalozLokate.UseVisualStyleBackColor = false;
            // 
            // Lokaty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.Controls.Add(this.bt_ZalozLokate);
            this.Name = "Lokaty";
            this.Size = new System.Drawing.Size(626, 479);
            this.Load += new System.EventHandler(this.Lokaty_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_ZalozLokate;
    }
}

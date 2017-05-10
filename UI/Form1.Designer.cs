namespace UI
{
    partial class Form1
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

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Wymagana metoda obsługi projektanta — nie należy modyfikować 
        /// zawartość tej metody z edytorem kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            BunifuAnimatorNS.Animation animation8 = new BunifuAnimatorNS.Animation();
            BunifuAnimatorNS.Animation animation9 = new BunifuAnimatorNS.Animation();
            BunifuAnimatorNS.Animation animation7 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.bt_Kredyty = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bt_Ustawienia = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bt_Wyloguj = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bt_Lokaty = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bt_Rachunki = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bt_Transakcje = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bt_SG = new Bunifu.Framework.UI.BunifuFlatButton();
            this.ButtonMenu = new Bunifu.Framework.UI.BunifuImageButton();
            this.logo = new System.Windows.Forms.PictureBox();
            this.Heder = new System.Windows.Forms.Panel();
            this.bunifuImageButton2 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.LogoAnimator = new BunifuAnimatorNS.Animator(this.components);
            this.PanelAnimator = new BunifuAnimatorNS.Animator(this.components);
            this.PanelAnimator2 = new BunifuAnimatorNS.Animator(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.Heder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.panel1.Controls.Add(this.bt_Kredyty);
            this.panel1.Controls.Add(this.bt_Ustawienia);
            this.panel1.Controls.Add(this.bt_Wyloguj);
            this.panel1.Controls.Add(this.bt_Lokaty);
            this.panel1.Controls.Add(this.bt_Rachunki);
            this.panel1.Controls.Add(this.bt_Transakcje);
            this.panel1.Controls.Add(this.bt_SG);
            this.panel1.Controls.Add(this.ButtonMenu);
            this.panel1.Controls.Add(this.logo);
            this.LogoAnimator.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator2.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 479);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // bt_Kredyty
            // 
            this.bt_Kredyty.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.bt_Kredyty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.bt_Kredyty.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_Kredyty.BorderRadius = 0;
            this.bt_Kredyty.ButtonText = "      Kredyty";
            this.bt_Kredyty.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelAnimator2.SetDecoration(this.bt_Kredyty, BunifuAnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this.bt_Kredyty, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator.SetDecoration(this.bt_Kredyty, BunifuAnimatorNS.DecorationType.None);
            this.bt_Kredyty.Iconcolor = System.Drawing.Color.Transparent;
            this.bt_Kredyty.Iconimage = ((System.Drawing.Image)(resources.GetObject("bt_Kredyty.Iconimage")));
            this.bt_Kredyty.Iconimage_right = null;
            this.bt_Kredyty.Iconimage_right_Selected = null;
            this.bt_Kredyty.Iconimage_Selected = null;
            this.bt_Kredyty.IconZoom = 90D;
            this.bt_Kredyty.IsTab = true;
            this.bt_Kredyty.Location = new System.Drawing.Point(-1, 287);
            this.bt_Kredyty.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bt_Kredyty.Name = "bt_Kredyty";
            this.bt_Kredyty.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.bt_Kredyty.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.bt_Kredyty.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(184)))));
            this.bt_Kredyty.selected = false;
            this.bt_Kredyty.Size = new System.Drawing.Size(202, 50);
            this.bt_Kredyty.TabIndex = 8;
            this.bt_Kredyty.Textcolor = System.Drawing.Color.Silver;
            this.bt_Kredyty.TextFont = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bt_Kredyty.Click += new System.EventHandler(this.bt_Kredyty_Click);
            // 
            // bt_Ustawienia
            // 
            this.bt_Ustawienia.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.bt_Ustawienia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.bt_Ustawienia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_Ustawienia.BorderRadius = 0;
            this.bt_Ustawienia.ButtonText = "     Ustawienia";
            this.bt_Ustawienia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelAnimator2.SetDecoration(this.bt_Ustawienia, BunifuAnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this.bt_Ustawienia, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator.SetDecoration(this.bt_Ustawienia, BunifuAnimatorNS.DecorationType.None);
            this.bt_Ustawienia.Iconcolor = System.Drawing.Color.Transparent;
            this.bt_Ustawienia.Iconimage = ((System.Drawing.Image)(resources.GetObject("bt_Ustawienia.Iconimage")));
            this.bt_Ustawienia.Iconimage_right = null;
            this.bt_Ustawienia.Iconimage_right_Selected = null;
            this.bt_Ustawienia.Iconimage_Selected = null;
            this.bt_Ustawienia.IconZoom = 90D;
            this.bt_Ustawienia.IsTab = true;
            this.bt_Ustawienia.Location = new System.Drawing.Point(-2, 343);
            this.bt_Ustawienia.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bt_Ustawienia.Name = "bt_Ustawienia";
            this.bt_Ustawienia.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.bt_Ustawienia.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.bt_Ustawienia.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(184)))));
            this.bt_Ustawienia.selected = false;
            this.bt_Ustawienia.Size = new System.Drawing.Size(202, 50);
            this.bt_Ustawienia.TabIndex = 7;
            this.bt_Ustawienia.Textcolor = System.Drawing.Color.Silver;
            this.bt_Ustawienia.TextFont = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bt_Ustawienia.Click += new System.EventHandler(this.bunifuFlatButton6_Click);
            // 
            // bt_Wyloguj
            // 
            this.bt_Wyloguj.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.bt_Wyloguj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.bt_Wyloguj.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_Wyloguj.BorderRadius = 0;
            this.bt_Wyloguj.ButtonText = "               Wyloguj";
            this.bt_Wyloguj.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelAnimator2.SetDecoration(this.bt_Wyloguj, BunifuAnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this.bt_Wyloguj, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator.SetDecoration(this.bt_Wyloguj, BunifuAnimatorNS.DecorationType.None);
            this.bt_Wyloguj.Iconcolor = System.Drawing.Color.Transparent;
            this.bt_Wyloguj.Iconimage = ((System.Drawing.Image)(resources.GetObject("bt_Wyloguj.Iconimage")));
            this.bt_Wyloguj.Iconimage_right = null;
            this.bt_Wyloguj.Iconimage_right_Selected = null;
            this.bt_Wyloguj.Iconimage_Selected = null;
            this.bt_Wyloguj.IconZoom = 90D;
            this.bt_Wyloguj.IsTab = true;
            this.bt_Wyloguj.Location = new System.Drawing.Point(1, 428);
            this.bt_Wyloguj.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bt_Wyloguj.Name = "bt_Wyloguj";
            this.bt_Wyloguj.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.bt_Wyloguj.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.bt_Wyloguj.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(184)))));
            this.bt_Wyloguj.selected = false;
            this.bt_Wyloguj.Size = new System.Drawing.Size(199, 50);
            this.bt_Wyloguj.TabIndex = 6;
            this.bt_Wyloguj.Textcolor = System.Drawing.Color.Silver;
            this.bt_Wyloguj.TextFont = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bt_Wyloguj.Click += new System.EventHandler(this.bt_Wyloguj_Click);
            // 
            // bt_Lokaty
            // 
            this.bt_Lokaty.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.bt_Lokaty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.bt_Lokaty.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_Lokaty.BorderRadius = 0;
            this.bt_Lokaty.ButtonText = "       Lokaty";
            this.bt_Lokaty.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelAnimator2.SetDecoration(this.bt_Lokaty, BunifuAnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this.bt_Lokaty, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator.SetDecoration(this.bt_Lokaty, BunifuAnimatorNS.DecorationType.None);
            this.bt_Lokaty.Iconcolor = System.Drawing.Color.Transparent;
            this.bt_Lokaty.Iconimage = ((System.Drawing.Image)(resources.GetObject("bt_Lokaty.Iconimage")));
            this.bt_Lokaty.Iconimage_right = null;
            this.bt_Lokaty.Iconimage_right_Selected = null;
            this.bt_Lokaty.Iconimage_Selected = null;
            this.bt_Lokaty.IconZoom = 90D;
            this.bt_Lokaty.IsTab = true;
            this.bt_Lokaty.Location = new System.Drawing.Point(-3, 231);
            this.bt_Lokaty.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bt_Lokaty.Name = "bt_Lokaty";
            this.bt_Lokaty.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.bt_Lokaty.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.bt_Lokaty.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(184)))));
            this.bt_Lokaty.selected = false;
            this.bt_Lokaty.Size = new System.Drawing.Size(203, 50);
            this.bt_Lokaty.TabIndex = 5;
            this.bt_Lokaty.Textcolor = System.Drawing.Color.Silver;
            this.bt_Lokaty.TextFont = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bt_Lokaty.Click += new System.EventHandler(this.bt_Lokaty_Click);
            // 
            // bt_Rachunki
            // 
            this.bt_Rachunki.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.bt_Rachunki.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.bt_Rachunki.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_Rachunki.BorderRadius = 0;
            this.bt_Rachunki.ButtonText = "      Rachunki";
            this.bt_Rachunki.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelAnimator2.SetDecoration(this.bt_Rachunki, BunifuAnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this.bt_Rachunki, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator.SetDecoration(this.bt_Rachunki, BunifuAnimatorNS.DecorationType.None);
            this.bt_Rachunki.Iconcolor = System.Drawing.Color.Transparent;
            this.bt_Rachunki.Iconimage = ((System.Drawing.Image)(resources.GetObject("bt_Rachunki.Iconimage")));
            this.bt_Rachunki.Iconimage_right = null;
            this.bt_Rachunki.Iconimage_right_Selected = null;
            this.bt_Rachunki.Iconimage_Selected = null;
            this.bt_Rachunki.IconZoom = 90D;
            this.bt_Rachunki.IsTab = true;
            this.bt_Rachunki.Location = new System.Drawing.Point(-2, 175);
            this.bt_Rachunki.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bt_Rachunki.Name = "bt_Rachunki";
            this.bt_Rachunki.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.bt_Rachunki.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.bt_Rachunki.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(184)))));
            this.bt_Rachunki.selected = false;
            this.bt_Rachunki.Size = new System.Drawing.Size(202, 50);
            this.bt_Rachunki.TabIndex = 4;
            this.bt_Rachunki.Textcolor = System.Drawing.Color.Silver;
            this.bt_Rachunki.TextFont = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bt_Rachunki.Click += new System.EventHandler(this.bunifuFlatButton3_Click);
            // 
            // bt_Transakcje
            // 
            this.bt_Transakcje.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.bt_Transakcje.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.bt_Transakcje.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_Transakcje.BorderRadius = 0;
            this.bt_Transakcje.ButtonText = "     Transakcje";
            this.bt_Transakcje.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelAnimator2.SetDecoration(this.bt_Transakcje, BunifuAnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this.bt_Transakcje, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator.SetDecoration(this.bt_Transakcje, BunifuAnimatorNS.DecorationType.None);
            this.bt_Transakcje.Iconcolor = System.Drawing.Color.Transparent;
            this.bt_Transakcje.Iconimage = ((System.Drawing.Image)(resources.GetObject("bt_Transakcje.Iconimage")));
            this.bt_Transakcje.Iconimage_right = null;
            this.bt_Transakcje.Iconimage_right_Selected = null;
            this.bt_Transakcje.Iconimage_Selected = null;
            this.bt_Transakcje.IconZoom = 90D;
            this.bt_Transakcje.IsTab = true;
            this.bt_Transakcje.Location = new System.Drawing.Point(0, 119);
            this.bt_Transakcje.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bt_Transakcje.Name = "bt_Transakcje";
            this.bt_Transakcje.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.bt_Transakcje.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.bt_Transakcje.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(184)))));
            this.bt_Transakcje.selected = false;
            this.bt_Transakcje.Size = new System.Drawing.Size(201, 50);
            this.bt_Transakcje.TabIndex = 3;
            this.bt_Transakcje.Textcolor = System.Drawing.Color.Silver;
            this.bt_Transakcje.TextFont = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bt_Transakcje.Click += new System.EventHandler(this.bunifuFlatButton2_Click);
            // 
            // bt_SG
            // 
            this.bt_SG.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.bt_SG.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.bt_SG.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_SG.BorderRadius = 0;
            this.bt_SG.ButtonText = "      Strona Główna";
            this.bt_SG.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelAnimator2.SetDecoration(this.bt_SG, BunifuAnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this.bt_SG, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator.SetDecoration(this.bt_SG, BunifuAnimatorNS.DecorationType.None);
            this.bt_SG.Iconcolor = System.Drawing.Color.Transparent;
            this.bt_SG.Iconimage = ((System.Drawing.Image)(resources.GetObject("bt_SG.Iconimage")));
            this.bt_SG.Iconimage_right = null;
            this.bt_SG.Iconimage_right_Selected = null;
            this.bt_SG.Iconimage_Selected = null;
            this.bt_SG.IconZoom = 90D;
            this.bt_SG.IsTab = true;
            this.bt_SG.Location = new System.Drawing.Point(-4, 63);
            this.bt_SG.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bt_SG.Name = "bt_SG";
            this.bt_SG.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.bt_SG.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.bt_SG.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(184)))));
            this.bt_SG.selected = true;
            this.bt_SG.Size = new System.Drawing.Size(207, 50);
            this.bt_SG.TabIndex = 2;
            this.bt_SG.Textcolor = System.Drawing.Color.Silver;
            this.bt_SG.TextFont = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bt_SG.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // ButtonMenu
            // 
            this.ButtonMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.LogoAnimator.SetDecoration(this.ButtonMenu, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator.SetDecoration(this.ButtonMenu, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator2.SetDecoration(this.ButtonMenu, BunifuAnimatorNS.DecorationType.None);
            this.ButtonMenu.Image = ((System.Drawing.Image)(resources.GetObject("ButtonMenu.Image")));
            this.ButtonMenu.ImageActive = null;
            this.ButtonMenu.Location = new System.Drawing.Point(165, 23);
            this.ButtonMenu.Name = "ButtonMenu";
            this.ButtonMenu.Size = new System.Drawing.Size(20, 20);
            this.ButtonMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ButtonMenu.TabIndex = 2;
            this.ButtonMenu.TabStop = false;
            this.ButtonMenu.Zoom = 10;
            this.ButtonMenu.Click += new System.EventHandler(this.ButtonMenu_Click);
            // 
            // logo
            // 
            this.PanelAnimator2.SetDecoration(this.logo, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator.SetDecoration(this.logo, BunifuAnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this.logo, BunifuAnimatorNS.DecorationType.None);
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.Location = new System.Drawing.Point(3, 6);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(161, 51);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo.TabIndex = 2;
            this.logo.TabStop = false;
            this.logo.Click += new System.EventHandler(this.logo_Click);
            // 
            // Heder
            // 
            this.Heder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.Heder.Controls.Add(this.bunifuImageButton2);
            this.Heder.Controls.Add(this.bunifuCustomLabel1);
            this.LogoAnimator.SetDecoration(this.Heder, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator.SetDecoration(this.Heder, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator2.SetDecoration(this.Heder, BunifuAnimatorNS.DecorationType.None);
            this.Heder.Dock = System.Windows.Forms.DockStyle.Top;
            this.Heder.Location = new System.Drawing.Point(0, 0);
            this.Heder.Name = "Heder";
            this.Heder.Size = new System.Drawing.Size(826, 35);
            this.Heder.TabIndex = 1;
            this.Heder.Paint += new System.Windows.Forms.PaintEventHandler(this.Heder_Paint);
            // 
            // bunifuImageButton2
            // 
            this.bunifuImageButton2.BackColor = System.Drawing.Color.SeaGreen;
            this.LogoAnimator.SetDecoration(this.bunifuImageButton2, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator.SetDecoration(this.bunifuImageButton2, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator2.SetDecoration(this.bunifuImageButton2, BunifuAnimatorNS.DecorationType.None);
            this.bunifuImageButton2.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton2.Image")));
            this.bunifuImageButton2.ImageActive = null;
            this.bunifuImageButton2.Location = new System.Drawing.Point(789, 5);
            this.bunifuImageButton2.Name = "bunifuImageButton2";
            this.bunifuImageButton2.Size = new System.Drawing.Size(25, 25);
            this.bunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton2.TabIndex = 3;
            this.bunifuImageButton2.TabStop = false;
            this.bunifuImageButton2.Zoom = 10;
            this.bunifuImageButton2.Click += new System.EventHandler(this.bunifuImageButton2_Click);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.PanelAnimator2.SetDecoration(this.bunifuCustomLabel1, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator.SetDecoration(this.bunifuCustomLabel1, BunifuAnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this.bunifuCustomLabel1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(216)))), ((int)(((byte)(255)))));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(12, 9);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(88, 21);
            this.bunifuCustomLabel1.TabIndex = 2;
            this.bunifuCustomLabel1.Text = "AG - Bank";
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.Heder;
            this.bunifuDragControl1.Vertical = true;
            // 
            // panel2
            // 
            this.LogoAnimator.SetDecoration(this.panel2, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator.SetDecoration(this.panel2, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator2.SetDecoration(this.panel2, BunifuAnimatorNS.DecorationType.None);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(200, 35);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(626, 479);
            this.panel2.TabIndex = 2;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // LogoAnimator
            // 
            this.LogoAnimator.AnimationType = BunifuAnimatorNS.AnimationType.ScaleAndRotate;
            this.LogoAnimator.Cursor = null;
            animation8.AnimateOnlyDifferences = true;
            animation8.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation8.BlindCoeff")));
            animation8.LeafCoeff = 0F;
            animation8.MaxTime = 1F;
            animation8.MinTime = 0F;
            animation8.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation8.MosaicCoeff")));
            animation8.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation8.MosaicShift")));
            animation8.MosaicSize = 0;
            animation8.Padding = new System.Windows.Forms.Padding(30);
            animation8.RotateCoeff = 0.5F;
            animation8.RotateLimit = 0.2F;
            animation8.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation8.ScaleCoeff")));
            animation8.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation8.SlideCoeff")));
            animation8.TimeCoeff = 0F;
            animation8.TransparencyCoeff = 0F;
            this.LogoAnimator.DefaultAnimation = animation8;
            // 
            // PanelAnimator
            // 
            this.PanelAnimator.AnimationType = BunifuAnimatorNS.AnimationType.HorizBlind;
            this.PanelAnimator.Cursor = null;
            animation9.AnimateOnlyDifferences = true;
            animation9.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation9.BlindCoeff")));
            animation9.LeafCoeff = 0F;
            animation9.MaxTime = 1F;
            animation9.MinTime = 0F;
            animation9.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation9.MosaicCoeff")));
            animation9.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation9.MosaicShift")));
            animation9.MosaicSize = 0;
            animation9.Padding = new System.Windows.Forms.Padding(0);
            animation9.RotateCoeff = 0F;
            animation9.RotateLimit = 0F;
            animation9.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation9.ScaleCoeff")));
            animation9.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation9.SlideCoeff")));
            animation9.TimeCoeff = 0F;
            animation9.TransparencyCoeff = 0F;
            this.PanelAnimator.DefaultAnimation = animation9;
            // 
            // PanelAnimator2
            // 
            this.PanelAnimator2.AnimationType = BunifuAnimatorNS.AnimationType.Leaf;
            this.PanelAnimator2.Cursor = null;
            animation7.AnimateOnlyDifferences = true;
            animation7.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation7.BlindCoeff")));
            animation7.LeafCoeff = 1F;
            animation7.MaxTime = 1F;
            animation7.MinTime = 0F;
            animation7.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation7.MosaicCoeff")));
            animation7.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation7.MosaicShift")));
            animation7.MosaicSize = 0;
            animation7.Padding = new System.Windows.Forms.Padding(0);
            animation7.RotateCoeff = 0F;
            animation7.RotateLimit = 0F;
            animation7.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation7.ScaleCoeff")));
            animation7.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation7.SlideCoeff")));
            animation7.TimeCoeff = 0F;
            animation7.TransparencyCoeff = 0F;
            this.PanelAnimator2.DefaultAnimation = animation7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(826, 514);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Heder);
            this.PanelAnimator.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator2.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ButtonMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.Heder.ResumeLayout(false);
            this.Heder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel Heder;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox logo;
        private Bunifu.Framework.UI.BunifuFlatButton bt_SG;
        private Bunifu.Framework.UI.BunifuImageButton ButtonMenu;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton2;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuFlatButton bt_Kredyty;
        private Bunifu.Framework.UI.BunifuFlatButton bt_Ustawienia;
        private Bunifu.Framework.UI.BunifuFlatButton bt_Wyloguj;
        private Bunifu.Framework.UI.BunifuFlatButton bt_Lokaty;
        private Bunifu.Framework.UI.BunifuFlatButton bt_Rachunki;
        private Bunifu.Framework.UI.BunifuFlatButton bt_Transakcje;
        private System.Windows.Forms.Panel panel2;
        private BunifuAnimatorNS.Animator PanelAnimator;
        private BunifuAnimatorNS.Animator LogoAnimator;
        private BunifuAnimatorNS.Animator PanelAnimator2;
    }
}


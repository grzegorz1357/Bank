using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class Form1 : Form
    {
        public static int id = 0;

        public Form1()
        {
            
            InitializeComponent();
            id = UI.Logowanie.return_id();
         
            if (!panel2.Controls.Contains(SG.Instance))
            {
                panel2.Controls.Add(SG.Instance);
                SG.Instance.Dock = DockStyle.Fill;
                SG.Instance.BringToFront();

            }
            else
            {
                SG.Instance.BringToFront();

            }

        }
        public static int set_id()
        {
            return id;
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
           
            if (!panel2.Controls.Contains(SG.Instance))
            {
                panel2.Controls.Add(SG.Instance);
                SG.Instance.Dock = DockStyle.Fill;
                SG.Instance.BringToFront();

            }
            else
            {
                SG.Instance.BringToFront();

            }
        }

        private void Heder_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            if (!panel2.Controls.Contains(Rachunki_lista.Instance))
            {
                panel2.Controls.Add(Rachunki_lista.Instance);
                Rachunki_lista.Instance.Dock = DockStyle.Fill;
                Rachunki_lista.Instance.BringToFront();

            }
            else
            {
                Rachunki_lista.Instance.BringToFront();

            }
        }

        private void bunifuFlatButton6_Click(object sender, EventArgs e)
        {
            if (!panel2.Controls.Contains(Ustawienia.Instance))
            {
                panel2.Controls.Add(Ustawienia.Instance);
                Ustawienia.Instance.Dock = DockStyle.Fill;
                Ustawienia.Instance.BringToFront();

            }
            else
            {
                Ustawienia.Instance.BringToFront();

            }
        }

        private void ButtonMenu_Click(object sender, EventArgs e)
        {
            if(panel1.Width==50)//lewy panel
            {
                logo.Visible = true;
                panel1.Visible = false;
                panel1.Width = 200;
                PanelAnimator.ShowSync(panel1);
                LogoAnimator.ShowSync(logo);
            }
            else if (panel1.Width == 200)
            {
                logo.Visible = false;
                LogoAnimator.Hide(logo);
                panel1.Visible = false;
                panel1.Width = 50;
                PanelAnimator2.ShowSync(panel1);
            
            }
        }

        private void logo_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            if (!panel2.Controls.Contains(Transakcje.Instance))
            {
                panel2.Controls.Add(Transakcje.Instance);
                Transakcje.Instance.Dock = DockStyle.Fill;
                Transakcje.Instance.BringToFront();
            }
            else
            {
                Transakcje.Instance.BringToFront();
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bt_Wyloguj_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bt_Lokaty_Click(object sender, EventArgs e)
        {
            if (!panel2.Controls.Contains(Lokaty.Instance))
            {
                panel2.Controls.Add(Lokaty.Instance);
                Lokaty.Instance.Dock = DockStyle.Fill;
                Lokaty.Instance.BringToFront();
            }
            else
            {
                Lokaty.Instance.BringToFront();
            }
        }

        private void bt_Kredyty_Click(object sender, EventArgs e)
        {
            if (!panel2.Controls.Contains(Kredyty.Instance))
            {
                panel2.Controls.Add(Kredyty.Instance);
                Kredyty.Instance.Dock = DockStyle.Fill;
                Kredyty.Instance.BringToFront();
            }
            else
            {
                Kredyty.Instance.BringToFront();
            }
        }
    }
}

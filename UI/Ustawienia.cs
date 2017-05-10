using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class Ustawienia : UserControl
    {
        private static Ustawienia _instance;
        public static Ustawienia Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Ustawienia();
                return _instance;
            }
        }
        public Ustawienia()
        {
            InitializeComponent();
        }

        private void bunifuThinButton1_Click(object sender, EventArgs e)
        {

        }

        private void Ustawienia_Load(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton3_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!panel2.Controls.Contains(Ustawienia_konta.Instance))
            {
                panel2.Controls.Add(Ustawienia_konta.Instance);
                Ustawienia_konta.Instance.Dock = DockStyle.Fill;
                Ustawienia_konta.Instance.BringToFront();
            }
            else
            {
                Ustawienia_konta.Instance.BringToFront();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!panel2.Controls.Contains(Ustawienia_OProgramie.Instance))
            {
                panel2.Controls.Add(Ustawienia_OProgramie.Instance);
                Ustawienia_OProgramie.Instance.Dock = DockStyle.Fill;
                Ustawienia_OProgramie.Instance.BringToFront();
            }
            else
            {
                Ustawienia_OProgramie.Instance.BringToFront();
            }
        }
    }
}

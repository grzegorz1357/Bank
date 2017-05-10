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
    public partial class Transakcje : UserControl
    {
        private static Transakcje _instance;
        public static Transakcje Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Transakcje();
                return _instance;
            }
        }
        public Transakcje()
        { 
            InitializeComponent();
        }


        private void Transakcje_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!panel2.Controls.Contains(Transakcje_Odbiorcy.Instance))
            {
                panel2.Controls.Add(Transakcje_Odbiorcy.Instance);
                Transakcje_Odbiorcy.Instance.Dock = DockStyle.Fill;
                Transakcje_Odbiorcy.Instance.BringToFront();
            }
            else
            {
                Transakcje_Odbiorcy.Instance.BringToFront();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!panel2.Controls.Contains(Transakcje_Cykliczne.Instance))
            {
                panel2.Controls.Add(Transakcje_Cykliczne.Instance);
                Transakcje_Cykliczne.Instance.Dock = DockStyle.Fill;
                Transakcje_Cykliczne.Instance.BringToFront();
            }
            else
            {
                Transakcje_Cykliczne.Instance.BringToFront();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!panel2.Controls.Contains(Transakcje_Przelewy.Instance))
            {
                panel2.Controls.Add(Transakcje_Przelewy.Instance);
                Transakcje_Przelewy.Instance.Dock = DockStyle.Fill;
                Transakcje_Przelewy.Instance.BringToFront();
            }
            else
            {
                Transakcje_Przelewy.Instance.BringToFront();
            }
        }
    }
}

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
    public partial class Transakcje_Przelewy : UserControl
    {
        private static Transakcje_Przelewy _instance;
        public static Transakcje_Przelewy Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Transakcje_Przelewy();
                return _instance;
            }
        }
        public Transakcje_Przelewy()
        {
            InitializeComponent();
        }

        private void Transakcje_Przelewy_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}

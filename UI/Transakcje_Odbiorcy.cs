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
    public partial class Transakcje_Odbiorcy : UserControl
    {
        private static Transakcje_Odbiorcy _instance;
        public static Transakcje_Odbiorcy Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Transakcje_Odbiorcy();
                return _instance;
            }
        }
        public Transakcje_Odbiorcy()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Transakcje_Odbiorcy_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}

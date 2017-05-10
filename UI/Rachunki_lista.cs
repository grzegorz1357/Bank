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
    public partial class Rachunki_lista : UserControl
    {
        private static Rachunki_lista _instance;
        public static Rachunki_lista Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Rachunki_lista();
                return _instance;
            }
        }
        public Rachunki_lista()
        {
            InitializeComponent();
        }

        private void Rachunki_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}

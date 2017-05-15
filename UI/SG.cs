using System;
using System.Windows.Forms;

namespace UI
{
    public partial class SG : UserControl
    {

        private static SG _instance;
        public static SG Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new SG();
                return _instance;
            }
        }
        public SG()
        {
            InitializeComponent();
           
        }



        private void SG_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

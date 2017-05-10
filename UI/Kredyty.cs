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
    public partial class Kredyty : UserControl
    {

        private static Kredyty _instance;
        public static Kredyty Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Kredyty();
                return _instance;
            }
        }

        public Kredyty()
        {
            InitializeComponent();
        }

        private void Kredyty_Load(object sender, EventArgs e)
        {

        }
    }
}

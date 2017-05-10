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
    public partial class Lokaty : UserControl
    {
        private static Lokaty _instance;
        public static Lokaty Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Lokaty();
                return _instance;
            }
        }

        public Lokaty()
        {
            InitializeComponent();
        }

        private void Lokaty_Load(object sender, EventArgs e)
        {

        }
    }
}

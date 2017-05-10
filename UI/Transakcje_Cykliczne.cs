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
    public partial class Transakcje_Cykliczne : UserControl
    {


        private static Transakcje_Cykliczne _instance;
        public static Transakcje_Cykliczne Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Transakcje_Cykliczne();
                return _instance;
            }
        }
        public Transakcje_Cykliczne()
        {
            InitializeComponent();
        }

        private void Transakcje_Cykliczne_Load(object sender, EventArgs e)
        {

        }
    }
}

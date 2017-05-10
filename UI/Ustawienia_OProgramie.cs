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
    public partial class Ustawienia_OProgramie : UserControl
    {

        private static Ustawienia_OProgramie _instance;
        public static Ustawienia_OProgramie Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Ustawienia_OProgramie();
                return _instance;
            }
        }
        public Ustawienia_OProgramie()
        {
            InitializeComponent();
        }

        private void Ustawienia_OProgramie_Load(object sender, EventArgs e)
        {

        }
    }
}

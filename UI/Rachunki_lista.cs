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
        public int ID = Form1.set_id();
       
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
            rachunki();
            srodki();
            dgv_rachunki_Load();
            dgv_rachunek.Columns[4].DefaultCellStyle.Format = "0.00##";
        }

        // TWORZENIE LISTY RACHUNKOW DLA DANEGO KLIENTA
        private void rachunki()
        {
            String login = ID.ToString();

            using (var wh = new Entities1())
            {

                var rachunki = (from r in wh.Rachunki
                                join k in wh.Klienci on r.id_klienta equals k.id_klienta
                                where k.login == login
                                select new 
                                {                                   
                                    Numer = r.nr_rachunku       
                                    
                                });
                cb_rachunki.DataSource = rachunki.ToList();
                cb_rachunki.ValueMember = "Numer";
                
            }

        }

        // SPRAWDZANIE DOSTEPNYCH SRODKOW DLA WYBRANEGO KONTA W COMBOBOXIE
        private void srodki()
        {
            String login = ID.ToString();
            String nr = cb_rachunki.SelectedItem.ToString();
            string selected = this.cb_rachunki.GetItemText(this.cb_rachunki.SelectedItem);
            lb_srodki.Text = "";
            String kwota = "";

            using (var wh = new Entities1())
            {

                var srodki = (from r in wh.Rachunki
                              join k in wh.Klienci on r.id_klienta equals k.id_klienta
                              where k.login == login && r.nr_rachunku == selected
                              select new
                                {
                                    s = r.dostepne_srodki
                                });
                // LINQ ZWRACA NAZWE POLA NP. { s = kwota }, KTORA TRZEBA WYCIAC (MOZE DA SIE JAKOS INACZEJ TEGO POZBYC)
                kwota = srodki.FirstOrDefault().ToString();
                int ind1 = kwota.IndexOf("{") +6;
                int ind2 = kwota.IndexOf(",") +3;
                lb_srodki.Text = kwota.Substring(ind1, ind2-ind1) + " PLN";
              //  lb_srodki.Text = kwota;
            }
        }

        private void Rachunki_Load(object sender, EventArgs e)
        {

        }

        private void cb_rachunki_SelectedIndexChanged(object sender, EventArgs e)
        {
           // srodki();
        }

        private void cb_rachunki_SelectionChangeCommitted(object sender, EventArgs e)
        {
            srodki();
            dgv_rachunki_Load();
        }

        // WYSWIETLNAIE HISTORII DLA WYBRANEGO RACHUNKU
        private void dgv_rachunki_Load()
        {
            

            String login = ID.ToString();
            string selected = this.cb_rachunki.GetItemText(this.cb_rachunki.SelectedItem);
            using (var wh = new Entities1())
            {

                var historia = (from h in wh.Historia_wewnatrzbankowa
                                join r in wh.Rachunki on h.id_rachunku_nadawca equals r.id_rachunku
                                join rr in wh.Rachunki on h.id_rachunku_odbiorca equals rr.id_rachunku
                                join k in wh.Klienci on r.id_klienta equals k.id_klienta
                                join kk in wh.Klienci on rr.id_klienta equals kk.id_klienta
                                where (k.login == login || kk.login == login) && (r.nr_rachunku == selected || rr.nr_rachunku==selected)
                                join s in wh.Historia_status on h.status equals s.id_status
                                orderby h.data descending
                                select new
                                {
                                    Data = h.data,
                                    Nadawca = r.nr_rachunku,
                                    Odbiorca = rr.nr_rachunku,
                                    Opis = h.tytul,
                                    Kwota = h.kwota,
                                    Status = s.nazwa
                                }).ToList();

                var historia2 = (from hm in wh.Historia_miedzybankowa
                                 join r in wh.Rachunki on hm.id_rachunku equals r.id_rachunku
                                 join k in wh.Klienci on r.id_klienta equals k.id_klienta
                                 where k.login == login && r.nr_rachunku == selected
                                 join s in wh.Historia_status on hm.status equals s.id_status
                                 orderby hm.data descending
                                 select new
                                 {
                                     Data = hm.data,
                                     Nadawca = r.nr_rachunku,
                                     Odbiorca = hm.nr_rachunku_obcego,
                                     Opis = hm.tytul,
                                     Kwota = hm.kwota,
                                     Status = s.nazwa
                                 }).ToList();

                historia.AddRange(historia2);
                historia.Sort((x, y) => x.Data.CompareTo(y.Data));
                historia.Reverse();
                dgv_rachunek.DataSource = historia.ToList();

            }
        }
      
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dgv_rachunek_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            dgv_rachunek.RowHeadersVisible = false;
            foreach (DataGridViewRow Myrow in dgv_rachunek.Rows)
            {
                Myrow.Cells["Kwota"].Style.ForeColor = Color.Green;
                Myrow.Cells["Status"].Style.ForeColor = Color.Black;
                Myrow.Cells["Data"].Style.ForeColor = Color.Black;
                Myrow.Cells["Odbiorca"].Style.ForeColor = Color.Black;
                Myrow.Cells["Nadawca"].Style.ForeColor = Color.Black;
                Myrow.Cells["Opis"].Style.ForeColor = Color.Black;
                for (int i = 0; i < cb_rachunki.Items.Count; i++)
                {

                    if ((Myrow.Cells["Nadawca"].Value.ToString() == cb_rachunki.GetItemText(cb_rachunki.Items[i])))
                    {
                       // Myrow.Cells["Kwota"].Value = Myrow.Cells["Kwota"].Value.ToString();
                        Myrow.Cells["Kwota"].Style.ForeColor = Color.Red;
                    }
                    if ((Myrow.Cells["Status"].Value.ToString().Contains("Anulowana")))
                    {
                        Myrow.Cells["Status"].Style.ForeColor = Color.Purple;
                        Myrow.Cells["Data"].Style.ForeColor = Color.Purple;
                        Myrow.Cells["Odbiorca"].Style.ForeColor = Color.Purple;
                        Myrow.Cells["Nadawca"].Style.ForeColor = Color.Purple;
                        Myrow.Cells["Opis"].Style.ForeColor = Color.Purple;
                    }
                }
            }
        }
    }
}

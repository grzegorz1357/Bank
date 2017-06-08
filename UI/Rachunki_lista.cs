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
<<<<<<< HEAD
       
=======

        
>>>>>>> origin/master
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
                                from r in wh.Rachunki.Where(s => s.id_rachunku == h.id_rachunku_nadawca || s.id_rachunku == h.id_rachunku_odbiorca)
                                join k in wh.Klienci on r.id_klienta equals k.id_klienta
                                where k.login == login && r.nr_rachunku == selected
                                orderby h.data descending
                                select new 
                                {
                                    Data = h.data,
                                    OdNad = r.nr_rachunku,
                                    Opis = h.tytul,
                                    Kwota = h.kwota
                                });
               
                dgv_rachunek.DataSource = historia.ToList();
            }
        }
      
        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}

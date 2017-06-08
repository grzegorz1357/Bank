using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using System.Linq;

namespace UI
{
    public partial class SG : UserControl
    {
        public int ID = Form1.set_id();

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
            logowanie();
            // lb_user.Text = data.Rows[0][0]
        }


        private void logowanie()
        {
            
            bool polaczenie = true;
            using (Entities1 bank = new Entities1())
            {
               
                try
                {
                    bank.Database.Connection.Open();
                    //bank.Database.Connection.Close();
                }

                catch (Exception blad_sieci)
                {

                    polaczenie = false;
                };
                bool dostep = true;
                bool istnieje = true;

                if (polaczenie == true)
                {
                    String login = ID.ToString();

                    if (bank.Database.Connection.State != ConnectionState.Open)
                    {
                        MessageBox.Show("Problem z nawiązaniem połączenia z bazą danych.", "Błąd systemu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                    // WYSWIETLNAIE POL Z IMIENIEM, NAZWISKIEM, DOSTEPNYMI SRODKAMI DLA ZALOGOWANEGO KLIENTA
                    using (var wh = new Entities1())
                    {
                        DataTable datad = new DataTable();
                    
                        var result = (from k in wh.Klienci where k.login == login
                                      select new 
                                        {
                                            imie = k.imie,
                                            nazwisko = k.nazwisko,
                                            data1 = k.data_ostatniego_logowania,
                                            data2 = k.data_ostatniego_blednego_logowania
                                        });

                        datad.Columns.Add("Imie");
                        datad.Columns.Add("Nazwisko");
                        datad.Columns.Add("Data1");
                        datad.Columns.Add("Data2");
                        foreach (var item in result)
                        {
                            DataRow newRow = datad.NewRow();
                            newRow["Imie"] = item.imie;
                            newRow["Nazwisko"] = item.nazwisko;
                            newRow["Data1"] = item.data1;
                            newRow["Data2"] = item.data2;
                            datad.Rows.Add(newRow);
                        }
                        String temp = datad.Rows[0][0].ToString() + " " + datad.Rows[0][1].ToString();
                        lb_user.Text = temp;
                        lb_last_login.Text = datad.Rows[0][2].ToString();
                        lb_last_login_error.Text = datad.Rows[0][3].ToString();
                    }

                    // WYSWIETLANIE SUMY SRODKOW ZE WSZYTKICH KONT ZALOGOWANEGO KLIENTA
                    using (var rr = new Entities1())
                    {
                        var rachunki = (from r in rr.Rachunki
                                        join k in rr.Klienci on r.id_klienta equals k.id_klienta
                                        where k.login == login && r.rodzaj_rachunku == 1
                                        select new
                                        {
                                            s = r.dostepne_srodki
                                        }).ToList();
                        var srodki = rachunki.Select(c => c.s).Sum();

                        int ind1 = srodki.ToString().IndexOf(",") + 3;
                        label2.Text = srodki.ToString().Remove(ind1) + " PLN";
                    }

                    // ZEBRANIE WSZYSTKICH RACHUNKÓW KLIENTA
                    using (var wh = new Entities1())
                    {

                        var rachunki = (from r in wh.Rachunki
                                        join k in wh.Klienci on r.id_klienta equals k.id_klienta
                                        where k.login == login
                                        select new
                                        {
                                            Numer = r.id_rachunku

                                        });

                        cb_hidden.DataSource = rachunki.ToList();
                    }

                    // WYSWIETLANIE HISTORII ZE WSZYSTKICH RACHUNKOW DLA ZALOGOWANEGO KLIENTA
                    // jeżeli rachunek nalezacy do klienta jest w polu nadawcy to wyswietlamy rachunek odbiorcy
                    // jeżeli rachunek nalezacy do klienta jest w polu odbiorcy to wyswietlamy rachunek nadawcy
                    using (var wh = new Entities1())
                    {

                        var historia = (from h in wh.Historia_wewnatrzbankowa
                                        from r in wh.Rachunki.Where(s => s.id_rachunku == h.id_rachunku_nadawca || s.id_rachunku == h.id_rachunku_odbiorca)
                                        join k in wh.Klienci on r.id_klienta equals k.id_klienta
                                        where k.login == login 
                                        orderby h.data descending
                                        select new
                                            {
                                                Data = h.data,
                                                OdNad = r.nr_rachunku,
                                                Opis = h.tytul,
                                                Kwota = h.kwota
                                            });

                        dgvHistoria.DataSource = historia.ToList();
                    }                
                }
                else MessageBox.Show("Błąd sieci. Sprawdź połączenie z Internetem.");
            }
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

        private void lb_user_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void cb_hidden_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dgvHistoria_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Drawing;
using System.Collections.Generic;

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
            dgvHistoria.Columns[4].DefaultCellStyle.Format = "0.00##";
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
                    using (var we = new Entities1())
                    {

                        var rachunki = (from r in we.Rachunki
                                        join k in we.Klienci on r.id_klienta equals k.id_klienta
                                        where k.login == login
                                        select new
                                        {
                                            Numer = r.nr_rachunku

                                        }).ToList();

                        cb_hidden.DataSource = rachunki;
                        cb_hidden.ValueMember = "Numer";

                        // WYSWIETLANIE HISTORII ZE WSZYSTKICH RACHUNKOW DLA ZALOGOWANEGO KLIENTA

                        using (var wh = new Entities1())
                        {
    
                            var historia = (from h in wh.Historia_wewnatrzbankowa
                                            join r in wh.Rachunki on h.id_rachunku_nadawca equals r.id_rachunku
                                            join rr in wh.Rachunki on h.id_rachunku_odbiorca equals rr.id_rachunku
                                            join k in wh.Klienci on r.id_klienta equals k.id_klienta
                                            join kk in wh.Klienci on rr.id_klienta equals kk.id_klienta
                                            where k.login == login || kk.login == login       
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
                                            where k.login == login
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
                            dgvHistoria.DataSource = historia;
                        }
                    }
                }
                else MessageBox.Show("Błąd sieci. Sprawdź połączenie z Internetem.");
            }
        }

        private void SG_Load(object sender, EventArgs e)
        {
            using (var rr = new Entities1())
            {
                var rachunki = (from r in rr.Rachunki
                                join k in rr.Klienci on r.id_klienta equals k.id_klienta
                                where k.login ==  ID.ToString() && r.rodzaj_rachunku == 1
                                select new
                                {
                                    s = r.dostepne_srodki
                                }).ToList();
                var srodki = rachunki.Select(c => c.s).Sum();

                int ind1 = srodki.ToString().IndexOf(",") + 3;
                label2.Text = srodki.ToString().Remove(ind1) + " PLN";
            }
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

        private void dgvHistoria_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

        }

        private void dgvHistoria_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvHistoria_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            dgvHistoria.RowHeadersVisible = false;

            foreach (DataGridViewRow Myrow in dgvHistoria.Rows)
            {
                Myrow.Cells["Kwota"].Style.ForeColor = Color.Green;
                Myrow.Cells["Status"].Style.ForeColor = Color.Black;
                Myrow.Cells["Data"].Style.ForeColor = Color.Black;
                Myrow.Cells["Odbiorca"].Style.ForeColor = Color.Black;
                Myrow.Cells["Nadawca"].Style.ForeColor = Color.Black;
                Myrow.Cells["Opis"].Style.ForeColor = Color.Black;
                for (int i = 0; i < cb_hidden.Items.Count; i++)
                {

                    if ((Myrow.Cells["Nadawca"].Value.ToString() == cb_hidden.GetItemText(cb_hidden.Items[i])))
                    {
                        //Myrow.Cells["Kwota"].Value = "-"+Myrow.Cells["Kwota"].Value.ToString();
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

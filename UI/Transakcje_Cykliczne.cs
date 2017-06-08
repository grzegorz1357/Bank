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
        private int ID = Form1.set_id();
        private DataTable datad = new DataTable();
       
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
            cykliczne();
            
            
        }

        private void Transakcje_Cykliczne_Load(object sender, EventArgs e)
        {

        }

        private void cb_rachunki_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //TWORZENIE LISTY PRZELEWÓW CYKLICZNYCH DANEGO KLIENTA
        private void cykliczne()
        {
            String login = ID.ToString();
            
            using (var wh = new Entities1())
            {

                var cykliczne = (
                                from pc in wh.Przelew_cykliczny
                                join r in wh.Rachunki on pc.id_rachunku_nadawcy equals r.id_rachunku
                                join kl in wh.Klienci on r.id_klienta equals kl.id_klienta
                                where kl.login == login
                                select new
                                {
                                    zRachunku = r.nr_rachunku,
                                    NaRachunek = pc.nr_rachunku_odbiorcy,
                                    kwota = pc.kwota,
                                    tytul = pc.tytuł,
                                    czestotliwosc = pc.Czestotliwosc_dni,
                                    dpw = pc.data_pierwszego_wykonania,
                                    dow = pc.data_ostatniego_wykonania,
                                    id_rachunku = pc.id_rachunku_nadawcy
                                });
                cb_przelewy.DataSource = cykliczne.ToList();
                cb_przelewy.ValueMember = "tytul";

                cb_ZRachunku.DataSource= cykliczne.ToList();
                cb_ZRachunku.ValueMember = "zRachunku";

                datad.Columns.Add("zRachunku");
                datad.Columns.Add("NaRachunek");
                datad.Columns.Add("kwota");
                datad.Columns.Add("tytul");
                datad.Columns.Add("czestotliwosc");
                datad.Columns.Add("dpw");
                datad.Columns.Add("dow");
                datad.Columns.Add("id_rachunku");
                foreach (var item in cykliczne)
                {
                    DataRow newRow = datad.NewRow();
                    newRow["zRachunku"] = item.zRachunku;
                    newRow["NaRachunek"] = item.NaRachunek;
                    newRow["kwota"] = item.kwota;
                    newRow["tytul"] = item.tytul;
                    newRow["czestotliwosc"] = item.czestotliwosc;
                    newRow["dpw"] = item.dpw;
                    newRow["dow"] = item.dow;
                    newRow["id_rachunku"] = item.id_rachunku;
                    datad.Rows.Add(newRow);
                }
                lb_ZRachunku.Text = datad.Rows[0][0].ToString();
                lb_NaRachunek.Text = datad.Rows[0][1].ToString();
                lb_Kwota.Text = datad.Rows[0][2].ToString();
                lb_Tytuł.Text = datad.Rows[0][3].ToString();
                lb_Czestotliwosc.Text = datad.Rows[0][4].ToString();
                lb_Dpw.Text = datad.Rows[0][5].ToString();
                lb_Dow.Text = datad.Rows[0][6].ToString();
                
            }
        }

        //WCZYTYWANIE DANYCH O POSZCZEGOlNYM PRZELEWIE
        private void cb_przelewy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (datad.Rows.Count !=0)
            {
                    for (int i = 0; i < datad.Rows.Count; i++)
                    {
                        if (cb_przelewy.SelectedValue.ToString() == datad.Rows[i][3].ToString())
                        {
                            lb_ZRachunku.Text = datad.Rows[i][0].ToString();
                            lb_NaRachunek.Text = datad.Rows[i][1].ToString();
                            lb_Kwota.Text = datad.Rows[i][2].ToString();
                            lb_Tytuł.Text = datad.Rows[i][3].ToString();
                            lb_Czestotliwosc.Text = datad.Rows[i][4].ToString();
                            lb_Dpw.Text = datad.Rows[i][5].ToString();
                            lb_Dow.Text = datad.Rows[i][6].ToString();

                        }
                    }
            }
        } 

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
        private void wyswietl_dodaj()
        {
            bt_Dodaj.Visible = false;
            bt_wyslij.Visible = true;
            bt_Anuluj.Visible = true;

            cb_ZRachunku.Visible = true;
            tb_NaRachunek.Visible = true;
            tb_Kwota.Visible = true;
            tb_Tytul.Visible = true;
            tb_Czestotliwosc.Visible = true;
            tb_dpw.Visible = true;
            tb_dow.Visible = true;

            lb_ZRachunku.Visible = false;
            lb_NaRachunek.Visible = false;
            lb_Kwota.Visible = false;
            lb_Tytuł.Visible = false;
            lb_Czestotliwosc.Visible = false;
            lb_Dpw.Visible = false;
            lb_Dow.Visible = false;
        }
        private void ukryj_dodaj()
        {
            bt_Anuluj.Visible = false;
            bt_Dodaj.Visible = true;
            bt_wyslij.Visible = false;

            cb_ZRachunku.Visible = false;
            tb_NaRachunek.Visible = false;
            tb_Kwota.Visible = false;
            tb_Tytul.Visible = false;
            tb_Czestotliwosc.Visible = false;
            tb_dpw.Visible = false;
            tb_dow.Visible = false;

            tb_NaRachunek.Clear();
            tb_Kwota.Clear();
            tb_Tytul.Clear();
            tb_Czestotliwosc.Clear();
            tb_dpw.Clear();
            tb_dow.Clear();

            lb_ZRachunku.Visible = true;
            lb_NaRachunek.Visible = true;
            lb_Kwota.Visible = true;
            lb_Tytuł.Visible = true;
            lb_Czestotliwosc.Visible = true;
            lb_Dpw.Visible = true;
            lb_Dow.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            wyswietl_dodaj();
        }

        private void bt_Anuluj_Click(object sender, EventArgs e)
        {
            ukryj_dodaj();
        }

        //WYSYŁANIE DANYCH O PRZELEWIE CYKLICZNYM DO SERWERA
        private void bt_wyslij_Click(object sender, EventArgs e)
        {
            Entities1 _repository = new Entities1();
            Przelew_cykliczny add = new Przelew_cykliczny();

            for(int i=0;i< datad.Rows.Count; i++)
            if (cb_ZRachunku.SelectedValue.ToString()== datad.Rows[i][0].ToString())
            {
                    int id = Int32.Parse(datad.Rows[i][7].ToString());
                    add.id_rachunku_nadawcy = id;
            }
           

            int odbiorca = Int32.Parse(tb_NaRachunek.Text.ToString());
            add.nr_rachunku_odbiorcy = odbiorca;

            var kwota = Convert.ToDecimal(tb_Kwota.Text.ToString());
            add.kwota = kwota;

            add.tytuł = tb_Tytul.Text.ToString();

            int czestotliwosc = Int32.Parse(tb_Czestotliwosc.Text.ToString());
            add.Czestotliwosc_dni = czestotliwosc;

            DateTime Data1 = DateTime.Parse(tb_dpw.Text.ToString());
            add.data_pierwszego_wykonania = Data1;

            DateTime Data2 = DateTime.Parse(tb_dow.Text.ToString());
            add.data_ostatniego_wykonania = Data2;

            try
            {
                _repository.Przelew_cykliczny.Add(add);
                _repository.SaveChanges();
                MessageBox.Show("Pomyślnie dodano przelew cykliczny");
                ukryj_dodaj();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}

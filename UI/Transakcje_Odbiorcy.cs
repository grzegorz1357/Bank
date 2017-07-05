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
    public partial class Transakcje_Odbiorcy : UserControl
    {
        private int ID = Form1.set_id();
        private DataTable data = new DataTable();
        private static Transakcje_Odbiorcy _instance;
        public static Transakcje_Odbiorcy Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Transakcje_Odbiorcy();
                return _instance;
            }
        }
        public Transakcje_Odbiorcy()
        {
            InitializeComponent();
            odbiorcy();
        }
        private void Transakcje_Odbiorcy_Load(object sender, EventArgs e)
        {

        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void odbiorcy()
        {
            String login = ID.ToString();
            using (var wh = new Entities1())
            {

                var odbiorcy = (
                    from od in wh.Odbiorcy_zdefiniowani
                    join kl in wh.Klienci on od.id_wlasciciela equals kl.id_klienta
                    where kl.login == login
                    select new
                    {
                        ID_Odbiorcy=od.id_odbiorcy_zdefiniowani,
                        ID_Wlasciciela=od.id_wlasciciela,
                        nazwa=od.nazwa,
                        adres=od.adres,
                        nr_Rachunku = od.nr_rachunku,
                    });
                cb_odbiorcy.DataSource = odbiorcy.ToList();
                cb_odbiorcy.ValueMember = "nazwa";

                data.Columns.Add("ID_Odbiorcy");
                data.Columns.Add("ID_Wlasciciela");
                data.Columns.Add("nazwa");
                data.Columns.Add("adres");
                data.Columns.Add("nr_Rachunku");
                foreach (var item in odbiorcy)
                {
                    DataRow newRow = data.NewRow();
                    newRow["ID_Odbiorcy"] = item.ID_Odbiorcy;
                    newRow["ID_Wlasciciela"] = item.ID_Wlasciciela; 
                    newRow["nazwa"] = item.nazwa;
                    newRow["adres"] = item.adres;
                    newRow["nr_Rachunku"] = item.nr_Rachunku;
                    data.Rows.Add(newRow);
                }
                lb_Nazwa.Text = data.Rows[0][2].ToString();
                lb_Adres.Text = data.Rows[0][3].ToString();
                lb_NRachunku.Text = data.Rows[0][4].ToString();
                
            }
        } 
        //WCZYTYWANIE DANYCH O POSZCZEGOlNYM ODBIORCY
        private void cb_odbiorcy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (data.Rows.Count != 0)
            {
                for (int i = 0; i < data.Rows.Count; i++)
                {
                    if (cb_odbiorcy.SelectedValue.ToString() == data.Rows[i][2].ToString())
                    {
                        lb_Nazwa.Text = data.Rows[i][2].ToString();
                        lb_Adres.Text = data.Rows[i][3].ToString();
                        lb_NRachunku.Text = data.Rows[i][4].ToString();


                    }
                }
            }
        }
        private void bt_wyslij_Click(object sender, EventArgs e)
        {
            if (sprawdz(tb_NumerRachunku.Text) != true)
            {
                MessageBox.Show("Numer rachunku jest nieprawidłowy");

            }
            else
            {
                Entities1 _repository = new Entities1();
                Odbiorcy_zdefiniowani add = new Odbiorcy_zdefiniowani();

                for (int i = 0; i < data.Rows.Count; i++)
                    if (cb_odbiorcy.SelectedValue.ToString() == data.Rows[i][2].ToString())
                    {
                        int id = Int32.Parse(data.Rows[i][1].ToString());
                        add.id_wlasciciela = id;
                    }
                add.nr_rachunku = tb_NumerRachunku.Text.ToString();
                add.nazwa = tb_Nazwa.Text.ToString();
                add.adres = tb_Adres.Text.ToString();

                try
                {
                    _repository.Odbiorcy_zdefiniowani.Add(add);
                    _repository.SaveChanges();
                    MessageBox.Show("Pomyślnie dodano kontakt");
                    ukryj_dodaj();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void bt_DodajOdbiorce_Click(object sender, EventArgs e)
        {
            wyswietl_dodaj();
        }
        private void bt_Anuluj_Click(object sender, EventArgs e)
        {
            ukryj_dodaj();
        }
        private void bt_przelew_Click(object sender, EventArgs e)
        {
            Transakcje_Przelewy.TurnOFF();
            Transakcje_Przelewy.TurnON();
            Transakcje_Przelewy.wgrajOdbiorce(lb_Nazwa.Text.ToString());
            Transakcje_Przelewy.wgrajAdres(lb_Adres.Text.ToString());
            Transakcje_Przelewy.wgrajRachunek(lb_NRachunku.Text.ToString());
            Transakcje.Instance.Przejdz_do_przelewu();
            this.Visible = false;

        }
        static bool sprawdz(string numer)
        {
            char[] temp = numer.ToCharArray();
            int[] numerT = Array.ConvertAll(temp, c => (int)Char.GetNumericValue(c));
            int licznik1 = 0;
            int licznik2 = 0;
            for (int i = 3; i < numerT.Length; i++)
            {
                if (i < 23)
                    licznik1 += numerT[i];
                if (i == 23)
                    licznik2 += numerT[i] * 100;
                if (i == 24)
                    licznik2 += numerT[i] * 10;
                if (i == 25)
                    licznik2 += numerT[i];
            }
            if (licznik1 == licznik2)
                return true;
            else
                return false;
        }

        private void wyswietl_dodaj()
        {
            bt_DodajOdbiorce.Visible = false;
            bt_wyslij.Visible = true;
            bt_Anuluj.Visible = true;
            bt_przelew.Visible = false;

            tb_Nazwa.Visible = true;
            tb_Adres.Visible = true;
            tb_NumerRachunku.Visible = true;

            lb_Nazwa.Visible = false;
            lb_Adres.Visible = false;
            lb_NRachunku.Visible = false;

        }
        private void ukryj_dodaj()
        {
            bt_Anuluj.Visible = false;
            bt_DodajOdbiorce.Visible = true;
            bt_wyslij.Visible = false;
            bt_przelew.Visible = true;

            tb_Nazwa.Visible = false;
            tb_Adres.Visible = false;
            tb_NumerRachunku.Visible = false;

            tb_Nazwa.Clear();
            tb_Adres.Clear();
            tb_NumerRachunku.Clear();

            lb_Nazwa.Visible = true;
            lb_Adres.Visible = true;
            lb_NRachunku.Visible = true;


        }

       
    }
}

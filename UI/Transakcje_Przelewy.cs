using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using System.Net;
using System.Net.Sockets;
using System.Xml.Serialization;
using System.Text.RegularExpressions;

namespace UI
{
    public partial class Transakcje_Przelewy : UserControl
    {
        private NetworkStream mainStream;
        private TcpClient client = new TcpClient();
        static IPAddress lokalne = IPAddress.Parse("127.0.0.1");

        private int ID = Form1.set_id();
        private DataTable data = new DataTable();
        private static Transakcje_Przelewy _instance;
        private static string odbiorca, adres, rachunek;
        public static Transakcje_Przelewy Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Transakcje_Przelewy();
                return _instance;
            }
        }
        public Transakcje_Przelewy()
        {
            InitializeComponent();
            ustawDane();
            UstawRachunki();

            Random random = new Random();
            lb_kod.Text = random.Next(10000, 99999).ToString();
        }

        public static void TurnON()
        {
             Transakcje_Przelewy _instance = new Transakcje_Przelewy();
        }

        public static void TurnOFF()
        {
            _instance = null;
        }

        private void Transakcje_Przelewy_Load(object sender, EventArgs e)
        {

        }
        private void UstawRachunki()
        {
            String login = ID.ToString();

            using (var wh = new Entities1())
            {

                var rachunki = (from r in wh.Rachunki
                                join k in wh.Klienci on r.id_klienta equals k.id_klienta
                                where k.login == login
                                select new
                                {
                                    Numer = r.nr_rachunku,
                                    stan = r.dostepne_srodki

                                });
                cb_ZRachunku.DataSource = rachunki.ToList();
                cb_ZRachunku.ValueMember = "Numer";

                data.Columns.Add("Numer");
                data.Columns.Add("stan");
                foreach (var item in rachunki)
                {
                    DataRow newRow = data.NewRow();
                    newRow["Numer"] = item.Numer;
                    newRow["stan"] = item.stan;
                    data.Rows.Add(newRow);
                }
                lb_DostepneSrodki.Text = data.Rows[0][1].ToString();
            }
        }
        //Ustawia dane pobrane z UserControl transakcje_odbiorcy
        private void ustawDane()
        {
            if (odbiorca != null)
            {
                tb_NazwaOdbiorcy.Text = odbiorca;
                tb_AdresOdbiorcy.Text = adres;
                tb_NumerRachunku.Text = rachunek;
            }
        }
        //Pobiera dane odbiorcy z UserControl transakcje_odbiorcy
        public static void wgrajOdbiorce(string Wodbiorca)
        {
            odbiorca = Wodbiorca;
        }

        private void cb_ZRachunku_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (data.Rows.Count != 0)
            {
                for (int i = 0; i < data.Rows.Count; i++)
                {
                    if (cb_ZRachunku.SelectedValue.ToString() == data.Rows[i][0].ToString())
                    {
                        lb_DostepneSrodki.Text = data.Rows[i][1].ToString();



                    }
                }
            }
        }

        // --||--
        public static void wgrajAdres(string Wadres)
        {
            adres = Wadres;
        }
        // --||--
        public static void wgrajRachunek(string Wrachunek)
        {
            rachunek = Wrachunek;
        }

        public class Transakcja_Lista
        {
            public int id_transakcji;
            public decimal kwota;
            public DateTime data;
            public int id_rachunku_nadawca;
            public int id_rachunku_odbiorca;
            public int status;
            public String tytul;
            public String nazwa_odbiorcy;
            public String adres_odbiorcy;

            public Transakcja_Lista() { }

            public Transakcja_Lista(decimal kwota, DateTime data, int id_rachunku_nadawca, int id_rachunku_odbiorca, int status, String tytul, String nazwa_odbiorcy, String adres_odbiorcy)
            {
                //this.id_transakcji = id_transakcji;
                this.kwota = kwota;
                this.data = data;
                this.id_rachunku_nadawca = id_rachunku_nadawca;
                this.id_rachunku_odbiorca = id_rachunku_odbiorca;
                this.status = status;
                this.tytul = tytul;
                this.nazwa_odbiorcy = nazwa_odbiorcy;
                this.adres_odbiorcy = adres_odbiorcy;
            }
        }

        private void Laczenie()
        {
            client.Connect(lokalne, 5000);
            MessageBox.Show("Połączono z serwerem");
        }

        private void Rozlaczenie()
        {
            client.Close();

        }

        private void Wysylanie(Transakcja_Lista obiekt)
        {
            var xmlSerializer = new XmlSerializer(typeof(Transakcja_Lista));

            //BinaryFormatter binFormatter = new BinaryFormatter();
            mainStream = client.GetStream();
            xmlSerializer.Serialize(mainStream, obiekt);
           //MessageBox.Show("Wyslano komunikat: " + obiekt);
        }

 
        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            try
            {
                client.Connect(lokalne, 5000);



                if (tb_kod.Text == lb_kod.Text)
                {
                    DateTime data_teraz = DateTime.Now;
                    int id_rachunku1;
                    int id_rachunku2;
                    String nr_rachunku1 = cb_ZRachunku.Text;
                    String nr_rachunku2 = tb_NumerRachunku.Text;
                    String nazwa_odbiorcy = tb_NazwaOdbiorcy.Text;
                    String adres_odbiorcy = tb_AdresOdbiorcy.Text;
                    String tytul = tb_TytulPrzelewu.Text;
                    String login = ID.ToString();



                    using (var wh = new Entities1())
                    {

                        var rachunki = (from r in wh.Rachunki
                                        where r.nr_rachunku == nr_rachunku1
                                        select new
                                        {
                                            n = r.id_rachunku
                                        }).ToString();

                        nr_rachunku1 = Regex.Match(rachunki, @"\d+").Value;
                        id_rachunku1 = Convert.ToInt32(nr_rachunku1);

                    }

                    using (var wh = new Entities1())
                    {

                        var rachunki = (from r in wh.Rachunki
                                        where r.nr_rachunku == nr_rachunku2
                                        select new
                                        {
                                            n = r.id_rachunku
                                        }).ToString();

                        nr_rachunku2 = Regex.Match(rachunki, @"\d+").Value;
                        id_rachunku2 = Convert.ToInt32(nr_rachunku2);
                    }

                    Transakcja_Lista tl = new Transakcja_Lista(Convert.ToDecimal(tb_Kwota.Text), data_teraz, id_rachunku1, id_rachunku2, 0, tytul, nazwa_odbiorcy, adres_odbiorcy);

                    Laczenie();
                    Wysylanie(tl);
                    Rozlaczenie();
                    tl = null;
                }
                else
                    MessageBox.Show("Wprowadzono nieprawidłowy kod!");
            }
            catch (Exception blad_sieciowy)
            {
                MessageBox.Show("Brak połączenia z serwerem!");

            }
        }

        private void tb_Kwota_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != ','))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {

                e.Handled = true;
            }

            if (Regex.IsMatch(tb_Kwota.Text, @"\,\d\d"))
            {
                e.Handled = true;
            }

            if (e.KeyChar == 8) 
            {
                e.Handled = false;
            }
        }
    }
}

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
using System.Threading;

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
        //Sprawdza poprawnosc numeru
        static bool sprawdz(string numer)
        {
            int[] tab = new int[20];
            bool jest = false;
            String pom;
            using (var wh = new Entities1())
            {

                var numery = (from r in wh.Banki_numery
                              select new
                              {
                                  r.numer
                              }).ToArray();

                for (int i = 0; i < numery.Length; i++)
                {
                    String result = numery[i].ToString();
                    pom = Regex.Match(result, @"\d+").Value;
                    tab[i] = Convert.ToInt32(pom);
                }
            }

            if (numer.Length!=26)
                return false;
            char[] temp = numer.ToCharArray();
            int[] numerT = Array.ConvertAll(temp, c => (int)Char.GetNumericValue(c));
            for (int i = 0; i < tab.Length; i++)
            {
                String nr = numerT[0].ToString() + numerT[1].ToString() + numerT[2].ToString();
                
                if (nr == tab[i].ToString())
                    jest = true;
            }
            if (jest == false) return false;
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
                        //lb_DostepneSrodki.Text = data.Rows[i][1].ToString();



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
            //public int id_rachunku_odbiorca;
            public String numer_odbiorcy;
            public int status;
            public String tytul;
            public String nazwa_odbiorcy;
            public String adres_odbiorcy;

            public Transakcja_Lista() { }

            public Transakcja_Lista(decimal kwota, DateTime data, int id_rachunku_nadawca, String numer_odbiorcy, int status, String tytul, String nazwa_odbiorcy, String adres_odbiorcy)
            {
                //this.id_transakcji = id_transakcji;
                this.kwota = kwota;
                this.data = data;
                this.id_rachunku_nadawca = id_rachunku_nadawca;
                //this.id_rachunku_odbiorca = id_rachunku_odbiorca;
                this.numer_odbiorcy = numer_odbiorcy;
                this.status = status;
                this.tytul = tytul;
                this.nazwa_odbiorcy = nazwa_odbiorcy;
                this.adres_odbiorcy = adres_odbiorcy;
            }
        }

        private void Laczenie()
        {
            client.Connect(lokalne, 5100);
           // MessageBox.Show("Zlecenie zostało przekazane do realizacji.");
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

        private void srodki()
        {
            String login = ID.ToString();
            String nr = cb_ZRachunku.SelectedItem.ToString();
            string selected = this.cb_ZRachunku.GetItemText(this.cb_ZRachunku.SelectedItem);
            lb_DostepneSrodki.Text = "";
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
                int ind1 = kwota.IndexOf("{") + 6;
                int ind2 = kwota.IndexOf(",") + 3;
                lb_DostepneSrodki.Text = kwota.Substring(ind1, ind2 - ind1) + " PLN";
                //  lb_srodki.Text = kwota;
            }
        }
 
        public void Zlecanie()
        {
            

            try
            {
                //client.Connect(lokalne, 5100);
                if (tb_Kwota.Text != "" && tb_NazwaOdbiorcy.Text != "" && tb_NumerRachunku.Text != "" && tb_TytulPrzelewu.Text != "" && tb_AdresOdbiorcy.Text != "" && tb_kod.Text != "")
                {
                    if (tb_Kwota.Text != "0")
                    {
                        if (tb_kod.Text == lb_kod.Text)
                        {
                            if (sprawdz(tb_NumerRachunku.Text) == true)
                            {

                                DateTime data_teraz = DateTime.Now;
                                int id_rachunku1;
                                int id_rachunku2;
                                String nr_rachunku1 = "";
                                String nr_rachunku2 = "";
                                String pom1, pom2;

                                this.Invoke(new MethodInvoker(delegate { nr_rachunku1 = cb_ZRachunku.Text; }));
                                nr_rachunku2 = tb_NumerRachunku.Text;
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
                                                    }).ToList();

                                    String result = rachunki[0].ToString();
                                    pom1 = Regex.Match(result, @"\d+").Value;
                                    id_rachunku1 = Convert.ToInt32(pom1);

                                }

                                /*
                                using (var wh = new Entities1())
                                {

                                    var rachunki = (from r in wh.Rachunki
                                                    where r.nr_rachunku == nr_rachunku2
                                                    select new
                                                    {
                                                        n = r.id_rachunku
                                                    }).ToList();

                                    if (rachunki.Count > 0)
                                    {
                                        String result = rachunki[0].ToString();
                                        pom2 = Regex.Match(result, @"\d+").Value;
                                        id_rachunku2 = Convert.ToInt32(pom2);
                                    }
                                    else id_rachunku2 = 1;
                                }
                                */

                                Transakcja_Lista tl = new Transakcja_Lista(Convert.ToDecimal(tb_Kwota.Text), data_teraz, id_rachunku1, nr_rachunku2, 0, tytul, nazwa_odbiorcy, adres_odbiorcy);

                                Laczenie();
                                Wysylanie(tl);
                                Rozlaczenie();
                                tl = null;

                                Random random = new Random();
                                this.Invoke(new MethodInvoker(delegate { lb_kod.Text = random.Next(10000, 99999).ToString(); }));

                                this.Invoke(new MethodInvoker(delegate { tb_Kwota.Text = "0"; }));
                                this.Invoke(new MethodInvoker(delegate { tb_NumerRachunku.Text = ""; }));
                                this.Invoke(new MethodInvoker(delegate { tb_NazwaOdbiorcy.Text = ""; }));
                                this.Invoke(new MethodInvoker(delegate { tb_AdresOdbiorcy.Text = ""; }));
                                this.Invoke(new MethodInvoker(delegate { tb_TytulPrzelewu.Text = ""; }));
                                this.Invoke(new MethodInvoker(delegate { tb_kod.Text = ""; }));

                            }
                            else MessageBox.Show("Numer rachunku jest nieprawidłowy");
                        }               
                        else
                            MessageBox.Show("Wprowadzono nieprawidłowy kod!");
                    }
                    else MessageBox.Show("Wprowadzono nieprawidłową kwotę przelewu!");
                }
                else MessageBox.Show("Nie wypełniono wszystkich wymaganych pól!");
            }
            catch (Exception blad_sieciowy)
            {
                MessageBox.Show("Brak połączenia z serwerem!" + blad_sieciowy.ToString());

            }
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
           

                new Thread(() => Zlecanie()).Start();
            
            
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

        private void tb_NumerRachunku_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void cb_ZRachunku_SelectionChangeCommitted(object sender, EventArgs e)
        {
            srodki();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Cryptography;


namespace UI
{
    public partial class Logowanie : Form
    {
        internal static int id_klienta=0;
        
        public Logowanie()
        {
            InitializeComponent();
         
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            bool polaczenie = true;
            string uzytkownik = tb_login.Text;
           
           
            // HASHOWANIE HASŁA PRZY POMOCY FUNKCJI SKRÓTU SHA256
            String hashcode = "";
            byte[] bytes = Encoding.UTF8.GetBytes(tb_haslo.Text);
            SHA256Managed crypt = new SHA256Managed();
            byte[] hash = crypt.ComputeHash(bytes);
            foreach (byte x in hash)
            {
                hashcode += x.ToString("x2");
            }

            // NAWIĄZYWANIE POŁĄCZENIA Z BAZĄ DANYCH
            using (Entities1 bank = new Entities1())
            {
                
                try
                {
                    bank.Database.Connection.Open();
                    bank.Database.Connection.Close();
                }

                catch (Exception blad_sieci) 
                { 
                   
                    polaczenie = false;
                };
                bool dostep = true;
                bool istnieje = true;
                int proby_logowan = 0; 

                if (polaczenie == true)
                {
                    bank.Database.Connection.Open();

                    if (bank.Database.Connection.State != ConnectionState.Open)
                    {
                        MessageBox.Show("Problem z nawiązaniem połączenia z bazą danych.", "Błąd systemu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                    // SPRAWDZENIE LOGINU I HASLA JEDNOCZEŚNIE
                    // WERSJA W LINQ
     
                    // SPRAWDZENIE CZY LOGIN I HASLO ISTNIEJA W BAZIE
                    using (var wh = new Entities1())
                    {
<<<<<<< HEAD

                        var result = (from k in wh.Klienci                                
                                        where k.login == tb_login.Text && k.haslo == hashcode
                                        select new
                                        {
                                           k.id_klienta 
                                           
                                        }).Count();
                        if (result < 1)
                        {
                            // JEZELI NIE ISTNIEJA TO SPRAWDZA CZY SAM LOGIN ISTNIEJE W BAZIE
                            using (var rs = new Entities1())
                            {

=======
<<<<<<< HEAD

                        var result = (from k in wh.Klienci                                
                                        where k.login == tb_login.Text && k.haslo == hashcode
                                        select new
                                        {
                                           k.id_klienta 
                                           
                                        }).Count();
                        if (result < 1)
                        {
                            // JEZELI NIE ISTNIEJA TO SPRAWDZA CZY SAM LOGIN ISTNIEJE W BAZIE
                            using (var rs = new Entities1())
                            {

>>>>>>> origin/master
                                var result2 = (from k in wh.Klienci
                                               where k.login == tb_login.Text
                                               select new
                                               {
                                                   k.id_klienta
                                               }).Count();
                                if (result2 == 1)
                                // JEZELI SAM LOGIN ISTNIEJE TO ZMIENIA DATE OSTATNIEGO BLEDNEGO LOGOWANIA I ZLICZA PROBY LOGOWAN
                                {
                                    
                                    proby_logowan++;
                                    if (proby_logowan == 4)
                                    {
                                        Klienci k = (from x in wh.Klienci
                                                     where x.login == tb_login.Text
                                                     select x).First();
                                        k.login_blokada = true;
                                    }
                                    
                                    Klienci kk = (from x in wh.Klienci
                                                 where x.login == tb_login.Text
                                                 select x).First();
                                    kk.data_ostatniego_blednego_logowania = DateTime.Now;

                                    rs.SaveChanges();
                                     
                                }
                                wh.SaveChanges();
                            }

                            MessageBox.Show("Podano błędne dane logowania.", "Błąd systemu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            dostep = false;
                            istnieje = false;
                            tb_login.Clear();
                            tb_haslo.Clear();
                        }
                        else
                        {
                            // SPRAWDZANIE CZY NA KONTO NAŁOŻONA JEST BLOKADA LOGOWANIA
                            using (var rs = new Entities1())
                            {

                                var blokada = (from k in wh.Klienci
                                               where k.login == tb_login.Text && k.login_blokada != false
                                               select new
                                               {
                                                   k.login_blokada
                                               }).Count();
                                if (blokada == 1)
                                {
                                    MessageBox.Show("Na konto danego użytkownika nałożona jest blokada logowania", "Błąd systemu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    dostep = false;
                                    istnieje = false;
                                    tb_login.Clear();
                                    tb_haslo.Clear();
                                }
                            }
                        }
                    }

                    // W PRZYPADKU POPRAWNEGO LOGOWANIA ZMIENIAMY DATE OSTATNIEGO LOGOWANIA
                    
                    if (dostep == true)
                    {
                        // WERSJA W LINQ
                        proby_logowan = 0;
<<<<<<< HEAD

                        using (var wh = new Entities1())
                        {

                            Klienci k = (from x in wh.Klienci
                                         where x.login == tb_login.Text
                                         select x).First();
                            k.data_ostatniego_logowania = DateTime.Now;
                                                                                         
                            wh.SaveChanges();
                        }

=======

                        using (var wh = new Entities1())
                        {

=======

                        var result = (from k in wh.Klienci                                
                                        where k.login == tb_login.Text && k.haslo == hashcode
                                        select new
                                        {
                                           k.id_klienta 
                                           
                                        }).Count();
                        if (result < 1)
                        {
                            // JEZELI NIE ISTNIEJA TO SPRAWDZA CZY SAM LOGIN ISTNIEJE W BAZIE
                            using (var rs = new Entities1())
                            {

                                var result2 = (from k in wh.Klienci
                                               where k.login == tb_login.Text
                                               select new
                                               {
                                                   k.id_klienta
                                               }).Count();
                                if (result2 == 1)
                                // JEZELI SAM LOGIN ISTNIEJE TO ZMIENIA DATE OSTATNIEGO BLEDNEGO LOGOWANIA
                                {
                                    proby_logowan++;
                                    Klienci k = (from x in wh.Klienci
                                                 where x.login == tb_login.Text
                                                 select x).First();
                                    k.data_ostatniego_blednego_logowania = DateTime.Now;

                                    rs.SaveChanges();

                                }
                                wh.SaveChanges();
                            }

                            MessageBox.Show("Podano błędne dane logowania.", "Błąd systemu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            dostep = false;
                            istnieje = false;
                            tb_login.Clear();
                            tb_haslo.Clear();
                        }
                        else
                        {
                            // SPRAWDZANIE CZY NA KONTO NAŁOŻONA JEST BLOKADA LOGOWANIA
                            using (var rs = new Entities1())
                            {

                                var blokada = (from k in wh.Klienci
                                               where k.login == tb_login.Text && k.login_blokada != false
                                               select new
                                               {
                                                   k.login_blokada
                                               }).Count();
                                if (blokada == 1)
                                {
                                    MessageBox.Show("Na konto danego użytkownika nałożona jest blokada logowania", "Błąd systemu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    dostep = false;
                                    istnieje = false;
                                    tb_login.Clear();
                                    tb_haslo.Clear();
                                }
                            }
                        }
                    }

                    // W PRZYPADKU POPRAWNEGO LOGOWANIA ZMIENIAMY DATE OSTATNIEGO LOGOWANIA
                    
                    if (dostep == true)
                    {
                        // WERSJA W LINQ
                  
                        using (var wh = new Entities1())
                        {

>>>>>>> origin/master
                            Klienci k = (from x in wh.Klienci
                                         where x.login == tb_login.Text
                                         select x).First();
                            k.data_ostatniego_logowania = DateTime.Now;
                                                                                         
                            wh.SaveChanges();
                        }

>>>>>>> origin/master
                        id_klienta = get_id();
                        this.Hide();
                        Form1 main = new Form1();
                        main.Show();
<<<<<<< HEAD
                                               
=======
<<<<<<< HEAD
                                               
=======
                        
                        
>>>>>>> origin/master
>>>>>>> origin/master
                    }
                }
                else MessageBox.Show("Błąd sieci! Sprawdź połączenie z Internetem. ");
            }

          
        }
        private int get_id()
        {
            int x=0;
            Int32.TryParse(tb_login.Text, out x);
            return x;
        }
        internal static int return_id()
        {
            return id_klienta;
        }
       
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Login_Click(object sender, EventArgs e)
        {

        }
    }
}

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
            this.Close();
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
            using (SqlConnection con = new SqlConnection(@"Server=tcp:projekt-bank.database.windows.net;Database=102;
                                                           User ID=grzegorz1357@projekt-bank;Password=Admin1357;Trusted_Connection=False;Encrypt=True;"))
            {
                try
                {
                    con.Open();
                }
                catch (Exception blad_sieci) 
                { 
                   
                    polaczenie = false;
                };
                bool dostep = true;
                bool istnieje = true;

                if (polaczenie == true)
                {


                    if (con.State != ConnectionState.Open)
                    {
                        MessageBox.Show("Problem z nawiązaniem połączenia z bazą danych.", "Błąd systemu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }


                    // SPRAWDZENIE LOGINU I HASLA JEDNOCZEŚNIE
                    DataTable data = new DataTable();
                    SqlDataAdapter sda0 = new SqlDataAdapter("SELECT Count(*) FROM Klienci WHERE login='" + tb_login.Text + "' AND haslo='" + hashcode + "'", con);
                    sda0.Fill(data);
                    if (data.Rows[0][0].ToString() == "0")
                    {
                        MessageBox.Show("Podano błędne dane logowania.", "Błąd systemu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        dostep = false;
                        istnieje = false;
                        tb_login.Clear();
                        tb_haslo.Clear();
                    }
                    data.Clear();


                    /* SPRAWDZENIE LOGINU
                    DataTable data = new DataTable();
                    SqlDataAdapter sda0 = new SqlDataAdapter("SELECT Count(*) FROM Klienci WHERE login='" + tb_login.Text + "'", con);
                    sda0.Fill(data);
                    if (data.Rows[0][0].ToString() == "0")
                    {
                        MessageBox.Show("Użytkownik o podanym loginie nie istnieje w bazie danych.", "Błąd systemu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        dostep = false;
                        istnieje = false;
                        tb_login.Clear();
                        tb_haslo.Clear();
                    }
                    data.Clear();

                     SPRAWDZENIE HASŁA
                    SqlDataAdapter sda1 = new SqlDataAdapter("SELECT Count(*) FROM Klienci WHERE login='" + tb_login.Text + "' AND haslo='" + hashcode + "'", con);
                    sda1.Fill(data);
                    if (data.Rows[0][0].ToString() == "0" && istnieje == true)
                    {
                        MessageBox.Show("Podano błędne hasło dla użytkownika.", "Błąd systemu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        dostep = false;
                        tb_login.Clear();
                        tb_haslo.Clear();
                    }
                    data.Clear();
                    */


                    if (dostep == true)
                    {
                        this.Hide();
                        Form1 main = new Form1();
                        main.Show();
                        con.Close();
                    }
                }
                else MessageBox.Show("Blad sieci");
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

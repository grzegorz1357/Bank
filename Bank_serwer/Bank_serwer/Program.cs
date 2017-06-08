
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Threading.Tasks;
using System.Collections;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;

namespace Bank_serwer
{

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

    class Program
    {
        static IPAddress lokalne = IPAddress.Parse("127.0.0.1");
        private TcpClient clientserv = new TcpClient();
        private static TcpListener server;
        private static NetworkStream netStream;
        private static String LocalIP;
        Queue<Transakcja_Lista> zlecenia = new Queue<Transakcja_Lista>();

        private void Start_Listening(int port)
        {
            server = new TcpListener(IPAddress.Any, port);
            server.Start();
            Console.WriteLine("Uruchomiono serwer na adresie: " + lokalne);
            clientserv = server.AcceptTcpClient();

        }

        private static void Stop_Listening()
        {
            server.Stop();
            Console.WriteLine("Zatrzymano serwer");
        }

        private void Wstaw_na_liste(Transakcja_Lista t, Queue<Transakcja_Lista> kolejka)
        {
            kolejka.Enqueue(t);
            Console.WriteLine("Dodano obiekt na listę zleceń");
        }

        private void Dodaj_z_listy_do_bazy( Queue<Transakcja_Lista> kolejka)
        {
            Entities _repository = new Entities();
            Historia_wewnatrzbankowa add = new Historia_wewnatrzbankowa();
            foreach (Transakcja_Lista t in kolejka)
            {
                add.kwota = t.kwota;
                add.id_rachunku_nadawca = t.id_rachunku_nadawca;
                add.id_rachunku_odbiorca = t.id_rachunku_odbiorca;
                add.tytul = t.tytul;
                //add.nazwa_odbiorcy = t.nazwa_odbiorcy;
                //add.adres_odbiorcy = t.adres_odbiorcy;
                add.data = t.data;
                add.status = 2;
                Console.WriteLine(add.kwota + " " + add.id_rachunku_nadawca + " " + add.id_rachunku_odbiorca +
                    " " + add.tytul + " " + add.nazwa_odbiorcy + " " + add.adres_odbiorcy + " " + add.data + " " + add.status);
                try
                {
                    _repository.Historia_wewnatrzbankowa.Add(add);
                    _repository.SaveChanges();
                    Console.WriteLine("Transakcje zostały dodane do bazy");
                }
                catch (System.Data.Entity.Validation.DbEntityValidationException dbEx)
                {
                    Exception raise = dbEx;
                    foreach (var validationErrors in dbEx.EntityValidationErrors)
                    {
                        foreach (var validationError in validationErrors.ValidationErrors)
                        {
                            string message = string.Format("{0}:{1}",
                                validationErrors.Entry.Entity.ToString(),
                                validationError.ErrorMessage);
                            raise = new InvalidOperationException(message, raise);
                        }
                    }
                   throw raise;
                }

            }
        }

        private void Odbieranie()
        {
            Transakcja_Lista tl;
            Console.WriteLine("Oczekiwanie na zlecenia transkacji...");
            //Socket client = server.AcceptSocket();
            while (true)
            {
                if (clientserv.Connected)
                {
                    netStream = clientserv.GetStream();
                    var xmlSerializer = new XmlSerializer(typeof(Transakcja_Lista));

                    tl = (Transakcja_Lista)xmlSerializer.Deserialize(netStream);

                    Console.WriteLine("Odebrano: " + tl.id_rachunku_nadawca + " | " + tl.id_rachunku_odbiorca + " | " + tl.kwota
                                       + " | " + tl.tytul + " | " + tl.nazwa_odbiorcy + " | " + tl.adres_odbiorcy + " | " + tl.data + " | " + tl.status);
                                                           
                    Console.WriteLine();

                    Wstaw_na_liste(tl, zlecenia);
                    Dodaj_z_listy_do_bazy(zlecenia);
                    netStream.Close();
                    tl = null;
                }
            }
            
        }

        static void Main(string[] args)
        {
            
            DateTime data_teraz = DateTime.Now;       
            Program p1 = new Program();
            
            Thread Nasluchuj = new Thread(() => p1.Start_Listening(5000));
            Nasluchuj.Start();
            Thread Odbierz = new Thread(p1.Odbieranie);
            Odbierz.Start();
            //Stop_Listening();

            Console.ReadLine();
        }
    }
}

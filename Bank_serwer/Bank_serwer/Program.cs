
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
using System.Text.RegularExpressions;

namespace Bank_serwer
{

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

    class Program
    {
        int istnieje = 0;
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
            String pom2="";
            int id_rachunku2=0;
            Entities _repository = new Entities();
            Historia_wewnatrzbankowa add = new Historia_wewnatrzbankowa();
            Historia_miedzybankowa add_out = new Historia_miedzybankowa();

            foreach (Transakcja_Lista t in kolejka)
            {
                using (var wh = new Entities())
                {

                    var rachunki = (from r in wh.Rachunki
                                    where r.nr_rachunku == t.numer_odbiorcy
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
                    //else id_rachunku2 = 1;
                }

                if (id_rachunku2 != 0)
                {
                    using (var wh = new Entities())
                    {
                        Rachunki r = (from x in wh.Rachunki
                                      where x.id_rachunku == t.id_rachunku_nadawca
                                      select x).First();
                        if (r.id_rachunku != null)
                            r.dostepne_srodki = r.dostepne_srodki - t.kwota;

                        Rachunki rr = (from x in wh.Rachunki
                                       where x.id_rachunku == id_rachunku2
                                       select x).First();
                        if (rr.id_rachunku != null)
                            rr.dostepne_srodki = rr.dostepne_srodki + t.kwota;

                        wh.SaveChanges();
                    }

                    add.kwota = t.kwota;
                    add.id_rachunku_nadawca = t.id_rachunku_nadawca;
                    add.id_rachunku_odbiorca = id_rachunku2;
                    add.tytul = t.tytul;
                    add.nazwa_odbiorcy = t.nazwa_odbiorcy;
                    add.adres_odbiorcy = t.adres_odbiorcy;
                    add.data = t.data;
                    add.status = 3;
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
                    // JEŻELI DRUGI RACHUNEK NIE ISTNIEJE W BAZIE DANYCH BANKU WPISUJEMY WSZYSTKO DO HIST. MIĘDZYBANKOWEJ
                else
                {
                    using (var wh = new Entities())
                    {
                        Rachunki_obce ro = (from x in wh.Rachunki_obce
                                           where x.numer == t.numer_odbiorcy
                                           select x).FirstOrDefault();

                        if (ro != null)
                        {
                            ro.dostepne_srodki = ro.dostepne_srodki + t.kwota;
                            wh.SaveChanges();
                            istnieje = 1;
                        }
                    }

                    if (istnieje == 1)
                    {
                        using (var wh = new Entities())
                        {
                            Rachunki r = (from x in wh.Rachunki
                                          where x.id_rachunku == t.id_rachunku_nadawca
                                          select x).FirstOrDefault();

                            if (r != null)
                            {
                                r.dostepne_srodki = r.dostepne_srodki - t.kwota;
                                wh.SaveChanges();
                            }
                        }

                        add_out.kierunek_transakcji = 1;
                        add_out.kwota = t.kwota;
                        add_out.id_rachunku = t.id_rachunku_nadawca;
                        add_out.nr_rachunku_obcego = t.numer_odbiorcy;
                        add_out.tytul = t.tytul;
                        add_out.nazwa_odbiorcy = t.nazwa_odbiorcy;
                        add_out.adres_odbiorcy = t.adres_odbiorcy;
                        add_out.data = t.data;
                        add_out.status = 3;
                        Console.WriteLine(add_out.kierunek_transakcji + " " + add_out.kwota + " " + add_out.id_rachunku +
                            " " + add_out.nr_rachunku_obcego + " " + add_out.tytul + " " + add_out.nazwa_odbiorcy + " " + add_out.adres_odbiorcy + " " + add_out.data + " " + add_out.status);
                    }
                    else
                    {
                        add_out.kierunek_transakcji = 1;
                        add_out.kwota = t.kwota;
                        add_out.id_rachunku = t.id_rachunku_nadawca;
                        add_out.nr_rachunku_obcego = t.numer_odbiorcy;
                        add_out.tytul = t.tytul;
                        add_out.nazwa_odbiorcy = t.nazwa_odbiorcy;
                        add_out.adres_odbiorcy = t.adres_odbiorcy;
                        add_out.data = t.data;
                        add_out.status = 1;
                        Console.WriteLine("Błąd - Transakcja anulowana: " + add_out.kierunek_transakcji + " " + add_out.kwota + " " + add_out.id_rachunku +
                            " " + add_out.nr_rachunku_obcego + " " + add_out.tytul + " " + add_out.nazwa_odbiorcy + " " + add_out.adres_odbiorcy + " " + add_out.data + " " + add_out.status);
                   
                    }
                        
                        try
                    {
                        _repository.Historia_miedzybankowa.Add(add_out);
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
        }

        private void Odbieranie()
        {
           
            Transakcja_Lista tl;
            Console.WriteLine("Oczekiwanie na zlecenia transkacji...");
            //Socket client = server.AcceptSocket();
            while (true)
            {

                if (clientserv.Connected == true && clientserv != null)
                {
                        netStream = clientserv.GetStream();
                        var xmlSerializer = new XmlSerializer(typeof(Transakcja_Lista));
                        
                           tl = (Transakcja_Lista)xmlSerializer.Deserialize(netStream);

                            Console.WriteLine("Odebrano: " + tl.id_rachunku_nadawca + " | " + tl.numer_odbiorcy + " | " + tl.kwota
                                               + " | " + tl.tytul + " | " + tl.nazwa_odbiorcy + " | " + tl.adres_odbiorcy + " | " + tl.data + " | " + tl.status);

                            Console.WriteLine();

                            Wstaw_na_liste(tl, zlecenia);
                            Dodaj_z_listy_do_bazy(zlecenia);
                            netStream.Close();
                            tl = null;
                            clientserv.Close();
                            netStream.Dispose();
                            Thread.CurrentThread.Join();
                }


            }
            
        }

        private volatile bool stopThread = false;
        private Thread workThread;

        private void StartThread()
        {
            if (workThread == null)
            {
                stopThread = false;
                workThread = new Thread(new ThreadStart(Odbieranie));

                workThread.Start();
            }
        }

        private void StopThread()
        {
            if (workThread != null)
            {
                stopThread = true;

                workThread.Join(); // This makes the code here pause until the Thread exits.

                workThread = null;
            }
        }

        static void Main(string[] args)
        {

            DateTime data_teraz = DateTime.Now;       
            Program p1 = new Program();
            
            Thread Nasluchuj = new Thread(() => p1.Start_Listening(5100));
            Nasluchuj.Start();

            Thread workThread = new Thread(() => p1.Odbieranie());
            workThread.Start();

           // Odbierz.Start();
            //Stop_Listening();
            
            

            Console.ReadLine();
        }
    }
}

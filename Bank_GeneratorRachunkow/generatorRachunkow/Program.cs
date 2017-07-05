using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace generatorRachunkow
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Ile rachunków wygenerowac");
            int ilosc = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj 3 cyfry banku");
            int bank = Convert.ToInt32(Console.ReadLine());

            for(int i = 0; i < ilosc; i++)
            {
                string test = generuj(bank);
                Thread.Sleep(50);
                using (StreamWriter sw = File.AppendText("numery.txt"))
                {
                    sw.WriteLine(test);
                }
                
            }

            
           
        }
        static string generuj(int bank)
        {
            int []bankT = NumbersIn(bank).ToArray();
            int [] numer = new int[26];

            if (bankT.Length == 3)
            {
                numer[0] = bankT[2];
                numer[1] = bankT[1];
                numer[2] = bankT[0];
            }
            else if (bankT.Length == 2)
            {
                numer[0] = 0;
                numer[1] = bankT[1];
                numer[2] = bankT[0];
            }
            else if (bankT.Length == 1)
            {
                numer[0] = 0;
                numer[1] = 0;
                numer[2] = bankT[0];
            }
            Random rnd = new Random();
            int licznik = 0;
            for(int i=3;i<23;i++)
            {
                int liczba = rnd.Next(0, 9);
                licznik += liczba;
                numer[i] = liczba;
            }
            int []licznikT= NumbersIn(licznik).ToArray();
            if (licznikT.Length == 3)
            {
                numer[23] = licznikT[2];
                numer[24] = licznikT[1];
                numer[25] = licznikT[0];
            }
            else if(licznikT.Length == 2)
            {
                numer[23] = 0;
                numer[24] = licznikT[1];
                numer[25] = licznikT[0];
            }
            else if (licznikT.Length == 1)
            {
                numer[23] = licznikT[0];
                numer[24] = 0;
                numer[25] = 0;
            }
            string s = new string(Array.ConvertAll(numer, x => (char)('0' + x)));
            return s;
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



        //konwertuje inta na tablice intów
        public static Stack<int> NumbersIn(int value)
        {
            if (value == 0) return new Stack<int>();

            var numbers = NumbersIn(value / 10);

            numbers.Push(value % 10);

            return numbers;
        }
    }
}

using System;
using System.Globalization;

namespace ConsoleDeneme
{
    class Program
    {
        static void Main(string[] args)
        {
            string zaman = null;
            DateTime saat24;
            string sonuc = null;
            
            Console.WriteLine("12lik saati(AM/PM) 24 saat formatına çevirir");
            Console.WriteLine("Saati 00:00:00AM formatında giriniz");
            zaman = Console.ReadLine();

            saat24 = DateTime.Parse(zaman);

            sonuc = saat24.ToString("HH:mm:ss");

            Console.WriteLine(sonuc);

        }
    }
}

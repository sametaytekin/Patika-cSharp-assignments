using System;

namespace Kelimeler
{
    class Program
    {
        static void Main(string[] args)
        {
            int miktar=0;
            string[] kelimeler;
            Console.WriteLine("Pozitif Miktar giriniz");
            
            try
            {
                miktar =Convert.ToInt32( Console.ReadLine());
            }
            catch (FormatException ex)
            {
                Console.WriteLine("String değer girmeyiniz");
                Console.WriteLine(ex.Message.ToString());
                throw;
            }

            kelimeler = new string[miktar];

            Console.WriteLine("Miktar kadar kelime giriniz");

            for(int i=0;i<kelimeler.Length;i++){
                kelimeler[i] = Console.ReadLine().ToString();
            }
            Console.WriteLine("*****************");

            Array.Reverse(kelimeler);

            foreach (var kelime in kelimeler)
            {
                Console.WriteLine(kelime);
            }
        }
    }
}

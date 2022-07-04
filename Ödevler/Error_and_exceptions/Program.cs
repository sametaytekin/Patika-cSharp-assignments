using System;

namespace Error_and_exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi=0,sayi2=0;

            Console.WriteLine("Bir sayı giriniz: ");
            

            try
            {
                sayi = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Yazı girilemez");
                Console.WriteLine(ex);
            }    

            try
            {
                sayi2 = sayi / 0;
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Sıfıra bölünemez!!!");
                Console.WriteLine(ex);
                
            }


            try
            {
                int sonuc = Int32.Parse(null);
            }
            catch(ArgumentNullException rx)
            {   
                Console.WriteLine("Null inte çevrilemez");
                Console.WriteLine(rx);
            }
            finally
            {
                Console.WriteLine("İşlemler bitmiştir.");
            }
        }
    }
}

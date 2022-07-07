using System;

namespace Bolunebilir
{
    class Program
    {
        static void Main(string[] args)
        {
            int miktar=0, bolen=0;
            int[] sayilar;
            Console.WriteLine("Miktar giriniz");
            try
            {
                miktar = Convert.ToInt32( Console.ReadLine());
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Yazı karakteri girmeyiniz");
                Console.WriteLine(ex.Message.ToString());
                throw;
            }

            if(miktar<0){
                Console.WriteLine("Miktar negatif olamaz");
            }

            Console.WriteLine("Bolen giriniz");

            try
            {
                bolen = Convert.ToInt32( Console.ReadLine());
            }
            catch (FormatException ex)
            {
                Console.WriteLine("String değer girmeyiniz");
                Console.WriteLine(ex.Message.ToString());
                throw;
            }

            sayilar=new int[miktar];

            Console.WriteLine("Girdiğiniz miktar kadar pozitif sayı giriniz");
            for(int i=0;i<sayilar.Length;i++){
                try
                {
                    sayilar[i] =Convert.ToInt32( Console.ReadLine());
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("String değer girmeyiniz");
                    Console.WriteLine(ex.Message.ToString());
                    throw;
                }
            }
            Console.WriteLine("Bölene eşit ve ya tam bölünebilen sayılar");

            for(int j=0;j<sayilar.Length;j++){
                if( sayilar[j]%bolen ==0 || sayilar[j] == bolen){
                    Console.WriteLine(sayilar[j]);
                }
            }

        }


    }
}

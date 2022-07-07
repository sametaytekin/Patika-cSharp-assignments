using System;

namespace CiftOlanlar
{
    class Program
    {
        static void Main(string[] args)
        {
            int miktar=0;
            int[] sayilar;

            Console.WriteLine("Bir miktar giriniz");
            try
            {
                miktar = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Yazı karakterleri girilemez");
                Console.WriteLine(ex.Message.ToString());
                throw;
            }
            //Extension method 
            bool positive = miktar.isPositive();


            if( !positive ){
                Console.WriteLine("Negatif sayı girmeyin");
            }

            try
            {
                 sayilar = new int[miktar];
            }
            catch (System.Exception)
            {
                Console.WriteLine("Miktar negatif sayı olamaz");
                throw;
            }


            Console.WriteLine("Miktar kadar sayı giriniz");
            for(int i=0;i<sayilar.Length;i++){
                try
                {
                    sayilar[i]= Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("Yazı karakteri girilemez");
                    Console.WriteLine(ex.Message.ToString());
                    throw;
                }
            }
            Console.WriteLine("Çift sayılar: ");

            for(int j=0;j<sayilar.Length;j++){
                if( sayilar[j]%2 == 0){
                    Console.Write(sayilar[j]+" ");
                }
            }


        }


    }

    public static class ExtensionSinif{
        public static bool isPositive(this int n){
            if(n>=0){
                return true;
            }
            return false;

        }
    }
}

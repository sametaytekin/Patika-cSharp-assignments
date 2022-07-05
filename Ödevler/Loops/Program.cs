using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("For ile basamak yapma");
            Console.WriteLine("Bir sayı giriniz");
            int sayi =Convert.ToInt32 (Console.ReadLine());


            for(int i=0;i<sayi;i++){
               

                for(int k=0;k<=i;k++){
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
            Console.WriteLine("");

            for(int i=0;i<sayi;i++){
                for(int k=sayi;k>i;k--){
                   Console.Write("*");
                }
                Console.WriteLine("");
            }


            Console.WriteLine("");
            /***************While örneği************/    
            Console.WriteLine("While örneği");
            int sayi2 = Convert.ToInt32( Console.ReadLine());
            int sayac=1,toplam=0;

            while (sayac <= sayi2)
            {
                toplam += sayac;
                sayac++;
            }

            Console.WriteLine("Ortalama: "+toplam/sayi2);
        }
    }
}

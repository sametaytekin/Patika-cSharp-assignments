using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Koleksiyonlar_Soru_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int temp=0;
            List<int> sayilar=new List<int>();
            List<int> kucukler=new List<int>();
            List<int> buyukler = new List<int>();

            Console.WriteLine("20 sayı giriniz");
            for(int i=0;i<20;i++){
                try
                {
                    temp=Convert.ToInt32( Console.ReadLine());

                    sayilar.Add(temp);
                }
                catch (FormatException)
                {
                    sayilar.Add(0);
                    Console.WriteLine("Sadece sayı giriniz");
                }
 
            }

            sayilar.Sort();
            //ilk 3 elemanını kucukler arrayListe ekleyeceğiz
            foreach (var item in sayilar)
            {
                Console.Write(item+" ");
            }
            for(int i=0;i<3;i++){
                kucukler.Add(sayilar[i]);
            }
            for(int i=19;i>=17;i--){
                buyukler.Add( sayilar[i]);
            }
                        
            
            int ortKucukler= Convert.ToInt32( kucukler.Average());
            int ortBuyukler =Convert.ToInt32( buyukler.Average());
            Console.WriteLine("");
            Console.WriteLine("En küçük 3 sayının ortalaması: "+ortKucukler);
            Console.WriteLine("En büyük 3 sayının ortalaması: "+ortBuyukler);
            


        }
    }
}

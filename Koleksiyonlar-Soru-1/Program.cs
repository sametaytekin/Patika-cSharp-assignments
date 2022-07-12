using System;
using System.Collections;

namespace Koleksiyonlar_Soru_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sayilar=new int[20];
            int temp=0;
            int toplamPrime=0, toplamNotPrime=0;
            ArrayList prime = new ArrayList();
            ArrayList notPrime = new ArrayList();
            Console.WriteLine("20 adet sayı giriniz");
            for(int i=0;i<20;i++){
                try
                {
                    
                    if((temp = Convert.ToInt32( Console.ReadLine() ) ) <0 ){
                        Console.WriteLine("Negatif sayı girmeyiniz");
                        continue;
                    }
                    sayilar[i]=temp;
                }
                catch (FormatException )
                {
                    Console.WriteLine("Sadece Sayı giriniz");
                    
                }
            }
           

           foreach (var item in sayilar)
           {
            switch (item.isPrime())
            {
                case true:
                prime.Add(item);
                break;
                case false:
                notPrime.Add(item);
                break;
                
            }

           }

            prime.Sort();
            prime.Reverse();
            Console.WriteLine("Asal Sayılar "+prime.Count+" adet ");
            foreach (int item in prime)
            {
                Console.Write(item+" ");
                toplamPrime += item;
            }
            Console.WriteLine(" ");

            notPrime.Sort();
            notPrime.Reverse();
            Console.WriteLine("Asal olmayan sayılar: "+notPrime.Count+" adet ");
            foreach(int item in notPrime){
                Console.Write(item +" ");
                toplamNotPrime += item;
            }
            int ortPrime= toplamPrime / prime.Count;
            Console.WriteLine("Asal sayıların ortalaması "+ortPrime);

            int ortNotPrime = toplamNotPrime / notPrime.Count;
            Console.WriteLine("Asal olmayanların ortalaması "+ortNotPrime);
            
        }

    }

    public static class ExtensionClass{
        public static bool isPrime(this int n){
            if(n<=1){
                return false;
            }

            for(int i=2;i<Math.Sqrt(n);i++){
                if(n%i==0){
                    return false; //notPrime ;
                }
            }
            return true;
        }

    }
}

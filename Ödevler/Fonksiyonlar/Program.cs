using System;

namespace Fonksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi1=0,sayi2=0;

            Console.WriteLine("Bir sayı giriniz ");

            try
            {
                sayi1 =Convert.ToInt32( Console.ReadLine() );
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message.ToString());
                throw;
            }
            Console.WriteLine("Bir sayı giriniz ");

            try
            {
                sayi2 = Convert.ToInt32( Console.ReadLine() );
            }
            catch (System.Exception)
            {
                
                throw;
            }

            int ikiSayininToplamiKaresi = karesiniAl(sayi1,sayi2);
            Console.WriteLine("Sayıların karesinin toplamı: "+ikiSayininToplamiKaresi);

            Metotlar fonksiyon = new Metotlar();
            fonksiyon.EkranaYazdirBosluklu("Merhaba");

            string yazi= "Hayat zor";
            fonksiyon.EkranaYazdirBosluklu(yazi);

            Console.WriteLine("");
            AltAltaYazdir(yazi);

        }

        static int karesiniAl(int a,int b){
            double sonuc=0;
            sonuc= Math.Pow(a,2) + Math.Pow(b,2);

            return (int)sonuc;
        }

        private static void AltAltaYazdir(string metin){
            foreach (var item in metin)
            {
                Console.WriteLine(item);
            }
            
        }
        
    }

    class Metotlar{
        public void EkranaYazdirBosluklu(string metin){

            Console.Write("\n");
            foreach (var item in metin)
            {
                
                Console.Write(item+" ");
            }
        }


    }
}

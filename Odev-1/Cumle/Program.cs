using System;

namespace Cumle
{
    class Program
    {
        static void Main(string[] args)
        {
            string cumle = null;
            int harfSayisi=0;
            Console.WriteLine("Bir Cümle Giriniz!");

            cumle = Console.ReadLine().ToString();

            harfSayisi = kacHarfVar(cumle);

            Console.WriteLine(harfSayisi);

            int kelimeSayisi =cumle.kacKelimeVar();
            Console.WriteLine(kelimeSayisi);
        }

        static int kacHarfVar(string metin){
            short miktar=0;
            foreach (char karakter in metin){
                if(karakter == ' '){
                    continue;
                }
                miktar++;
            }
            return miktar+1;
        }

    }

    public static class MYExtension{
        public static int kacKelimeVar (this string metin){
            int miktar=0;
            foreach (char karakter in metin)
            {
                if(karakter == ' '){
                    miktar++;
                }
            }
            return miktar;
        }
    }
}

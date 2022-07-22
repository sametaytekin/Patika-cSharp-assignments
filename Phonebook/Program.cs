using System;
using System.Collections.Generic;

namespace Phonebook
{
    class Program
    {
        static void Main(string[] args)
        {
            int secim;
            string isim,soyisim,numara;
            string arama;



            Dictionary<string,string> yeniRehber = new 
            Dictionary<string, string>();
            
            //Rastgele beş kayıt ekledik
            yeniRehber.Add("MEHMET KORKMAZ","2122569126");
            yeniRehber.Add("AYŞE KIRMAZ","5356123478");
            yeniRehber.Add("AYŞE TOPAL","2123526894");
            yeniRehber.Add("HAKAN GÜL","5354681212");
            yeniRehber.Add("MELİKE GÜLER","5418427891");


            PhonebookManager RehberManager = new PhonebookManager(yeniRehber);

            Console.WriteLine("Çıkmak için (0) giriniz \nDevam etmek için rastgele sayı giriniz");

            secim =secimAl();

            while (secim!=0)
            {
                RehberManager.AnaMenu();
                Console.WriteLine("Çıkmak için (0) seçiniz");
                secim =secimAl();

                switch (secim)
                {
                case 1:
                    RehberManager.YeniNumaraSor();
                    isim = Console.ReadLine().ToString().ToUpper();
                    soyisim = Console.ReadLine().ToString().ToUpper();
                    numara = Console.ReadLine().ToString();
                    RehberManager.Ekle(isim,soyisim,numara);
                    break;
                case 2:
                    RehberManager.NumaraSilSor();
                    arama = Console.ReadLine().ToString().ToUpper().Trim();
                    RehberManager.Sil(arama);
                    break;
                case 3:    
                    RehberManager.NumaraGuncelle();
                    arama = Console.ReadLine().ToString().ToUpper().Trim();
                    RehberManager.Guncelle(arama);
                    break;
                case 4:
                    RehberManager.Listele();
                    break;
                case 5:
                    RehberManager.Ara();
                    break;    

                }

            }





        }

        public static int secimAl(){
            int secim;
            try
            {
                secim = Convert.ToByte( Console.ReadLine().ToString() );
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Yazı karakteri girmeyiniz");
                Console.WriteLine(ex.Message.ToString());
                throw;
            }catch( NullReferenceException rx){
                Console.WriteLine("Boş bırakmayınız");
                Console.WriteLine(rx.Message.ToString());
                throw;
            }

            return secim;
        }
    }
}

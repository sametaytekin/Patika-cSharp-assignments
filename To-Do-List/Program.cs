using System;
using System.Collections.Generic;

namespace To_Do_List
{
    class Program
    {
        static void Main(string[] args)
        {
            bool secim;
            int sonuc=1;
            string kartBaslik,kartIcerik;
            int ID=0;
            int kartBuyukluk=0;
            string baslikAra;

            Console.WriteLine("Devam etmek için Sıfır dışında rakam giriniz");
            //Yetkili kişiler
            Dictionary<int,string> yetkiliKisiler = new Dictionary<int, string>();
            yetkiliKisiler.Add(0,"Ahmet");
            yetkiliKisiler.Add(1,"Mehmet");
            yetkiliKisiler.Add(2,"Ayşe");
            yetkiliKisiler.Add(3,"Veysel");


            //Ön tanımlı kartlar
            List<Kart> onTanimli = new List<Kart>();
            onTanimli.Add(new Kart("YEMEK","Makarna yap",yetkiliKisiler[0],KartBoyutu.S));
            onTanimli.Add( new Kart("SPOR","2 Km koş",yetkiliKisiler[1],KartBoyutu.M));

            Board liste = new Board(onTanimli);
            
            //Sürekli çalışması için döngüde. Sıfır girilince program duruyor
            while (sonuc != 0)
            {   Menu();
                Console.WriteLine("Çıkmak için 0 seçiniz");
                secim = Int32.TryParse( Console.ReadLine(),out sonuc );
                if(!secim)
                    Console.WriteLine("Yazı karakteri girmeyiniz");
                switch (sonuc)
             {
                
                case 1:
                liste.BoardListele();
                    break;
                case 2:
                    KartEkleEkrani();

                    kartBaslik = Console.ReadLine().ToString().ToUpper();
                    kartIcerik = Console.ReadLine().ToString();
                    try
                    {
                        kartBuyukluk = Int32.Parse( Console.ReadLine());
                        ID=Int32.Parse( Console.ReadLine());
                    }
                    catch (FormatException fex)
                    {
                        Console.WriteLine("Harf girmeyiniz");
                        throw;
                    }

                    if( !yetkiliKisiler.ContainsKey(ID)){
                        Console.WriteLine("Yanlış Giriş Yaptınız");
                        break;
                    }
                    Kart eklenecekKart = 
                    new Kart(kartBaslik,kartIcerik,yetkiliKisiler[ID],(KartBoyutu)kartBuyukluk);

                    liste.BoardKartEkle(eklenecekKart);              

                 break;

                case 3:
                    Console.WriteLine("Öncelikle silmek istediğiniz kartı seçmeniz gerekiyor.");
                    Console.WriteLine("Lütfen kart başlığı yazınız");
                    baslikAra= Console.ReadLine().ToString().ToUpper();
                    liste.BoardKartSil(baslikAra);
                    break;

                case 4:
                    Console.WriteLine("Öncelikle taşımak istediğiniz kartı seçmeniz gerekiyor.");
                    Console.WriteLine("Lütfen kart başlığı yazınız");
                    baslikAra =Console.ReadLine().ToString().ToUpper();
                    liste.BoardKartTasi(baslikAra);

                    break;
            }


            }    





            
            
            
            
            
            }

            public static void KartEkleEkrani(){
                Console.WriteLine("Başlık giriniz".PadRight(50)+":");
                Console.WriteLine("İçerik giriniz".PadRight(50)+":");
                Console.WriteLine("Büyüklük seçiniz-> XS(1) ,S(2) ,M(3) ,L(4) ,XL(5) ".PadRight(50)+":");
                Console.WriteLine("Kişi seçiniz, ID giriniz".PadRight(50)+":");                
            }

            public static void Menu(){
             Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz\n*********");
            Console.WriteLine("(1) Board Listelemek");
            Console.WriteLine("(2) Boarda Kart Eklemek");
            Console.WriteLine("(3) Board'dan Kart silmek");
            Console.WriteLine("(4) Kart Taşımak");               
            }




        }
        public enum KartBoyutu
        {
        Default,
        XS,
        S,
        M,
        L,
        XL
        }
    }





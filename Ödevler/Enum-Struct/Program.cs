using System;

namespace Enum_Struct
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Urun dolap = new Urun("Eşya",155,Seviyeler.GirisSeviyesi);
            Urun pc = new Urun("PC",9000,Seviyeler.OrtaSeviye);
            Urun kahveMakinesi = new Urun("Kahve Makinesi",3200,Seviyeler.LuksSeviye);

            Musteri kisi1 = new Musteri("Ahmet",212);
            kisi1.Fis(kahveMakinesi);

        }
    }



    enum Seviyeler{
        GirisSeviyesi,
        OrtaSeviye,
        LuksSeviye,         
        
    }

    struct Musteri{
        public string isim;
        public int musteriNo;

        public Musteri(string ad,int no){
            isim=ad;
            musteriNo=no;
        }
        
        public void Fis(Urun esya){
            Console.WriteLine("Müşteri adı {0} Urun bilgileri {1} {2}",this.isim,esya.Seviye,esya.Tur);
        }

    }

    class Urun{
        private int fiyat;
        private Seviyeler seviye;

        private static int urunSayisi=0;

        private string tur;

        public int Fiyat { get => fiyat; set => fiyat = value; }
        public string Tur { get => tur; set => tur = value; }
        internal Seviyeler Seviye { get => seviye; set => seviye = value; }
        public static int UrunSayisi { get => urunSayisi; }

         static Urun(){
            urunSayisi++;
        }

        public Urun(){}

        public Urun(string türü, int fiyatı, Seviyeler seviye){
            if(fiyatı<0)
                fiyatı=0;
            Fiyat=fiyatı;
            Seviye=seviye;
            Tur=türü;
        }

        public void BilgileriYazdir(){
            Console.WriteLine("Fiyatı {0} Türü{1} Seviye {2}",Fiyat,Tur,Seviye);
        }

    }
}

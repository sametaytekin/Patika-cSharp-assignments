using System;

namespace Static_Ornek
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Çalışan sayısı {0}",Calisan.CalisanSayisi);

            Calisan calisan = new Calisan("Ayşe","Korkmaz","Satış Departmanı");
            Calisan calisan2 = new Calisan("Ahmet","Kayar","İK");

            Console.WriteLine("Çalışan sayısı {0}",Calisan.CalisanSayisi);

        }
    }

    class Calisan{
        private static int calisanSayisi;

        public static int CalisanSayisi { get => calisanSayisi; }
        public string Isim { get => isim; set => isim = value; }
        public string Soyisim { get => soyisim; set => soyisim = value; }
        public string Departman { get => departman; set => departman = value; }

        private string isim;
        private string soyisim;
        private string departman;

        public Calisan(){}

        static Calisan(){
            calisanSayisi=0;
        }

        public Calisan(string ad,string soyad,string departman){
            this.Isim = ad;
            this.Soyisim=soyad;
            this.Departman=departman;
            calisanSayisi++;
        }
    }
}

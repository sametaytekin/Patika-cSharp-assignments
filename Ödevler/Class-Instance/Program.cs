using System;

namespace Class_Instance
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("İsim soyisim yaş şehir giriniz");

            Personel kisi1 = new Personel();
            Console.WriteLine("İsim giriniz:");
            kisi1.Isim =  Console.ReadLine().ToString();

            Console.WriteLine("Soyisim giriniz");
            kisi1.SoyIsim = Console.ReadLine().ToString();

            Console.WriteLine("Yaş giriniz");
            kisi1.Yas = Convert.ToInt32( Console.ReadLine() );

            Console.WriteLine("Şehir giriniz");
            kisi1.Sehir= Console.ReadLine().ToString();

            Console.WriteLine("kisi1 Bilgileri");
            kisi1.BilgileriYazdir();

            Personel kisi2 = new Personel(){
                Isim="Ahmet",
                SoyIsim="Güler",
                Yas=25,
                Sehir="İzmir"
            };

            Console.WriteLine("kisi2 Bilgileri");
            kisi2.BilgileriYazdir();
        }
    }

    class Personel{
        string isim;
        string soyIsim;
        int yas;
        string sehir;

        public string Isim { get => isim; set => isim = value; }
        public string SoyIsim { get => soyIsim; set => soyIsim = value; }
        public int Yas { get => yas; set => yas = value; }
        public string Sehir { get => sehir; set => sehir = value; }

        public void BilgileriYazdir(){
            Console.WriteLine("İsim: {0} Soyisim: {1} Yaş: {2} Şehir {3}",Isim.PadLeft(10),SoyIsim.PadLeft(10),Yas.ToString().PadLeft(10),Sehir.PadLeft(10));
        }
    }
}

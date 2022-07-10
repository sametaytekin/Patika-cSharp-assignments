using System;
using System.Collections.Generic;

namespace Generic_Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Kullanicilar> deneme = new List<Kullanicilar>();
            Kullanicilar kisi1 = new Kullanicilar();
            kisi1.Isim="Ahmet";
            kisi1.Soyİsim="Yaşar";
            kisi1.Yas=18;

            Personel kisi2 = new Personel();
            kisi2.Isim="Cemil";
            kisi2.Yas=28;
            kisi2.Soyİsim="Yenilmez";
            kisi2.Gorev="Güvenlik görevlisi";

            Mudur kisi3 = new Mudur(){
                    Isim="Melek",
                    Soyİsim="Mutlu",
                    Yas=25,
                    Bolum="Satış Müdürü",
                    Gorev="Toplantı"
                    
                };

            Personel kisi4 = new Personel(){
                Isim="Melike",
                Soyİsim="Korkmaz",
                Yas= 25,
                Gorev="Sekreter"

            };    
            
            deneme.Add(kisi1);
            deneme.Add(kisi2);
            deneme.Add(kisi3);
            deneme.Add(kisi4);

            deneme.ForEach(x => Console.WriteLine(x.Isim.PadRight(10)+ x.Yas));

            deneme.Remove(kisi3);
            deneme.RemoveAt(0);

            Console.WriteLine("Listenin büyüklüğü \n"+deneme.Count);
            //Tüm listeyi silmek için Clear metodu
            deneme.Clear();
            
        }

    }

    public class Kullanicilar{
        string isim;
        string soyİsim;
        int yas;

        public string Isim { get => isim; set => isim = value; }
        public string Soyİsim { get => soyİsim; set => soyİsim = value; }
        public int Yas { get => yas; set => yas = value; }
    }

    class Personel : Kullanicilar{
        string gorev;

        public string Gorev { get => gorev; set => gorev = value; }
    }

    class Mudur : Kullanicilar
    {
        string gorev;
        string bolum;

        public string Gorev { get => gorev; set => gorev = value; }
        public string Bolum { get => bolum; set => bolum = value; }
    }
}

using System;

namespace Phonebook

{
    public abstract class Menu{

        public abstract void NumaraSilSor();

        public abstract void NumaraGuncelle();
        
        public void AnaMenu(){
            Console.WriteLine("Bir işlem seçiniz");
            Console.WriteLine("*******");
            Console.WriteLine("(1) Yeni numara kaydetmek");
            Console.WriteLine("(2) Varolan numarayı silmek");
            Console.WriteLine("(3) Varolan numarayı güncelle");
            Console.WriteLine("(4) Rehberi listele");
            Console.WriteLine("(5) Rehberde arama yap");
        }

        public void YeniNumaraSor(){
            Console.WriteLine("Lütfen isim giriniz:");
            Console.WriteLine("Lütfen soyisim giriniz");
            Console.WriteLine("Lütfen numara giriniz");

        }


        public virtual void Bulunamadi(){
            Console.WriteLine("Aradığınız kriterlere göre uygun veri bulunamadı.Bir seçim yapınız:");

        }

        public void NumaraAra(){
            Console.WriteLine("Arama yapmak istediğiniz tipi seçiniz\n************");
            Console.WriteLine("İsim ve ya soyisime göre arama yapmak için(1)");
            Console.WriteLine("Numaraya göre arama yapmak için(2)");
        }
        

    }
}
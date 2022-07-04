using System;

namespace Type_Conversion
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Implicit Dönüşümler*/
            Console.WriteLine("Implicit Dönüşümler");
            short kucuk = 5; byte enKucuk=3; int buyuk=0;

            Console.WriteLine("byte değeri: "+enKucuk+" short değeri: "+kucuk+" int değeri: "+buyuk);

            kucuk = enKucuk;
            Console.WriteLine("byte shorta sorunsuz dönüşebiliyor: "+kucuk);

            kucuk= 27;
            Console.WriteLine("short değeri değiştirildi: "+kucuk);
            buyuk = kucuk;
            Console.WriteLine("short int sorunsuz dönüşebiliyor: "+buyuk);

            buyuk= kucuk + enKucuk;
            Console.WriteLine("int değeri: "+buyuk);

            string metin= "visual studio code ";
            Console.WriteLine("String : "+metin);

            char karakter = '9';
            Console.WriteLine("Char: "+karakter);

            string metin2 = metin + karakter;
            Console.WriteLine("char veri tipi stringe implicit dönüşüebiliyor");
            Console.WriteLine(metin2);

            /*Explicit dönüşümler*/
            Console.WriteLine("Explicit dönüşümler");

            int a = 55;
            byte b=0;
            Console.WriteLine("int değer: "+a+" byte değer: "+b);

            b= (byte)a;
            Console.WriteLine("Dönüşümden sonra byte değeri: "+b);

            float sayi = 65.6f;
            int denemeSayi = 0;
            denemeSayi = (int)sayi;
            Console.WriteLine("floattan int döküm: "+denemeSayi);

            Console.WriteLine("ToString metodu ile (sayıları stringe çevirme)");
            int sayi1= 256;
            double sayi2 = 787.00;
            float sayi3 = 65.6f;
            string sayilar= sayi1.ToString();
            Console.WriteLine(sayilar);
            sayilar += " "+sayi2.ToString();
            Console.WriteLine(sayilar);
            sayilar += " "+sayi3.ToString();
            //arada boşluk olsun diye " " eklendi
            Console.WriteLine(sayilar);

            /*system.convert sınıfı ile*/
            Console.WriteLine("System.convert sınıfı ile (Stringi sayılara çevirme)");

            string sayi4 = "255";
            string sayi5 = "67";
            sayilar = sayi4 +sayi5;
            Console.WriteLine("string değerler toplamı: "+sayilar);

            int sayi6 = Convert.ToInt32(sayi4);
            int sayi7 = Convert.ToInt32(sayi5);

            int toplam = sayi6 + sayi7;
            Console.WriteLine("int değerler toplamı: "+toplam);

            /*Parse metodu ile*/
            string donusecekMetin = "452";
            string donusecekMetin2 = "202,25";

            int sayiyaDonustu = Int32.Parse(donusecekMetin);
            Console.WriteLine("Parse ile Stringten inte dönüştü: "+sayiyaDonustu);

            double sayiyaDonustu2 = double.Parse(donusecekMetin2);
            Console.WriteLine("Parse ile stringten double dönüştü: "+sayiyaDonustu2);

        }
    }
}

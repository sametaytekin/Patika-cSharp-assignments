using System;

namespace DateTime_Math
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine(DateTime.Now.ToString("hh:mm:ss"));
            Console.WriteLine(DateTime.Now.ToString("HH:mm:ss"));
            //sayı olarak tarihi yazar
            Console.WriteLine(DateTime.Now.ToString("dd:MM:yy"));
            //Kısa yazı olarak tarihi yazar
            Console.WriteLine(DateTime.Now.ToString("ddd:MMM:yyy"));
            //Uzun yazı olarak tarihi yazar
            Console.WriteLine(DateTime.Now.ToString("dddd:MMMM:yyyy"));


            Console.WriteLine("Gün:"+DateTime.Now.Day);
            Console.WriteLine("Ay:"+DateTime.Now.Month);
            Console.WriteLine("Yıl:"+DateTime.Now.Year);

            Console.WriteLine(DateTime.Now.ToLongDateString());
            Console.WriteLine(DateTime.Now.ToLongTimeString());

            Console.WriteLine(DateTime.Now.ToShortDateString());
            Console.WriteLine(DateTime.Now.ToShortTimeString());

            Console.WriteLine(DateTime.Now.DayOfWeek);
            Console.WriteLine(DateTime.Now.DayOfYear);
            Console.WriteLine("*************");

            Console.WriteLine("Girilen sayıyı aşağıya yuvarlayan metod Math.Ceiling 3,4 girildi");
            Console.WriteLine(Math.Ceiling(3.4));
            Console.WriteLine("Girilen sayıyı yukarıya yuvarlayan metod Math.Floor 3,6 girildi");
            Console.WriteLine(Math.Floor(3.6));
            Console.WriteLine("Math.Round Girilen sayıyı en yakın tabana yuvarlar 3,6 girildi");
            Console.WriteLine(Math.Round(3.6));
            Console.WriteLine("Sayının mutlak değerini Math.Abs verir, girilen sayı -75");
            Console.WriteLine(Math.Abs(-75));

            Console.WriteLine("Math.Max İki sayıdan büyük olanı bulur 3 ve 8 girildi");
            Console.WriteLine(Math.Max(3,8));
            Console.WriteLine("Math.Min iki sayıdan küçüğü bulur 3 ve 8 girildi");
            Console.WriteLine(Math.Min(3,8));

            Console.WriteLine("Üs alma işlemi Math.pow ile yapılır 2^3");
            Console.WriteLine(Math.Pow(2,3));
            Console.WriteLine("Karekök alma sqrt ile örneğin 81");
            Console.WriteLine(Math.Sqrt(81));

            Console.WriteLine("Sabit sayılar da vardır");
            Console.WriteLine("Pi: "+Math.PI);
            Console.WriteLine("e sayısı: "+Math.E);

        }
    }
}

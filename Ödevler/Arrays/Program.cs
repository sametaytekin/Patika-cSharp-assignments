using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string metin ="kelimeler";
            char[] char_dizisi= metin.ToCharArray();
            /*Stringi bir char dizisi olarak düşünebiliriz*/
            for(int i=0;i<char_dizisi.Length;i++){
               Console.Write( char_dizisi[i]+" ");
            }

            int[] sayilar = {34,1,64,77,231,6};
            Console.WriteLine("\nSort metodundan önce");

            for (int i = 0; i <sayilar.Length; i++)
            {
                Console.Write(sayilar[i]+" ");
            }

            Array.Sort(sayilar);

            Console.WriteLine("\nSort metodundan sonra");
            foreach (var item in sayilar)
            {
                Console.Write(item+" ");
            }

            Console.WriteLine("\nResize ile boyut artmadan önce");
            foreach (var item in sayilar)
            {
                Console.Write(item+" ");
            }

            Array.Resize<int>(ref sayilar,11);

            Console.WriteLine("\nResize ile boyut arttıktan sonra");
            for (int i = 0; i < sayilar.Length; i++)
            {
                Console.Write(sayilar[i]+" ");
            }

            Console.WriteLine("\nResize ile boyut azaltmadan önce");
            foreach (var item in sayilar)
            {
                Console.Write(item+" ");
            }

            Array.Resize<int>(ref sayilar,4);

            Console.WriteLine("\nResize ile boyut azalttıktan sonra");
            for (int i = 0; i < sayilar.Length; i++)
            {
                Console.Write(sayilar[i]+" ");
            }            

            
        }
    }
}

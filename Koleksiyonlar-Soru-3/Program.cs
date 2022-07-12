using System;
using System.Text.RegularExpressions;

namespace Koleksiyonlar_Soru_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string metin;
            Console.WriteLine("Cümle yazınız\n");
            metin = Console.ReadLine().ToString().ToLower();

            //Regular expressions ile ünlü olmayan harfleri çıkardım
            char[] result = Regex.Replace(metin,"[^aeıioöuü]","").ToCharArray();
            
            Console.WriteLine("Sesli harfler:");
            foreach (var item in result)
            {
                Console.Write(item+" ");
            }
        }
    }
}

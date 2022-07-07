using System;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = "Merhaba Dünya Nasılsın";
            string str2 = "Dünya";

            
            //str2 , str1 içinde varsa 1 döner
            Console.WriteLine(str1.CompareTo(str2));
            
            //İlk stringe ikinci stringi ekler
            Console.WriteLine(String.Concat(str1," İyimisin"));
            //Compare metodu
            Console.WriteLine(String.Compare(str1,"merhaba Dünya Nasılsın",true));
            Console.WriteLine(String.Compare(str1,"Merhaba Dünya Nasılsın",false));

            Console.WriteLine("BÜYÜK BİR ŞEYLER YAZINIZ");
            //Trim komutu boşlukları siler
            string str3 = Console.ReadLine().ToString().ToLower().Trim();
            Console.WriteLine("Girilen yazı küçük olarak: \n"+str3);    
            //\n kendinden sonrakileri alt satıra atar

            //str1 içinde str2 aramak için contains metodunu kullanabiliriz
            // bize bool türünde br değer döner
            Console.WriteLine("Metinimiz: "+str1);
            Console.WriteLine( str1.Contains(str2));

            Console.WriteLine("metin 'Nasılsın' ile bitiyor mu kontrol ediyoruz");
            Console.WriteLine( str1.EndsWith("Nasılsın"));

            Console.WriteLine("Metin 'Merhaba' ile başlıyor mu kontrol ediyoruz");
            Console.WriteLine(str1.StartsWith("Merhaba"));

            Console.WriteLine("aradığımız parçanın metindeki indexini gösterir.\n Dünya arıyoruz");
            Console.WriteLine(str1.IndexOf("Dünya"));

            Console.WriteLine(str1.LastIndexOf("n"));

            //Belli bir yerden metine string ekleyebiliyoruz
            Console.WriteLine(str1.Insert(7," Güzel"));


            //Padleft,Padright
            Console.WriteLine( str1 +str3.PadLeft(15));
            Console.WriteLine(str1.PadRight(25)+ str3);

            Console.WriteLine(str1 +str2.PadLeft(15,'x'));
            Console.WriteLine(str1.PadRight(25,'-')+str2);
            Console.WriteLine("");

            Console.WriteLine("Remove metodu bu örnekte 13. indexten sonrasını siler");
            Console.WriteLine(str1.Remove(13));    
            Console.WriteLine("Örnekte 10.indexten sonra 5 karakter sildik.");
            Console.WriteLine(str1.Remove(10,5).ToUpper());

            //Replace metodu
            Console.WriteLine("Replace metodu ile seçtiğimiz karakter ve ya texti değiştirebiliyoruz");
            Console.WriteLine(str1.Replace("Dünya","Faniler"));
            Console.WriteLine(str1.Replace(" ","+"));


            Console.WriteLine("Split ile belli karaktere göre metini faklı stringlere ayırabiliyoruz");
            Console.WriteLine("");
            string[] s2 =str1.Split(' ');

            foreach (var item in s2)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("\nSubstring ile belli indexten sonraki metini alabiliyoruz\n");
            Console.WriteLine(str1.Substring(11));
            
        }
    }
}

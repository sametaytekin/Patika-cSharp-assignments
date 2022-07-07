using System;

namespace Extension_Recursive
{
    class Program
    {
        static void Main(string[] args)
        {
            int sonuc=0,sayi;
            Console.WriteLine("Bir sayi giriniz: ");
            try
            {
              sayi =Convert.ToInt32( Console.ReadLine() );   
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Sadece sayi giriniz !");
                Console.WriteLine(ex.Message.ToString());
                throw;
            }

            sonuc = factorial(sayi);
            Console.WriteLine("Girilen sayının faktöriyeli: "+sonuc);
            Console.WriteLine("*********");
            
            bool prime = sayi.isPrime();
            switch (prime)
            {
                case true:
                Console.WriteLine("Sayı asaldır.");
                break;
                case false:
                Console.WriteLine("Sayı asal değildir");
                break;
            }
            
        }

        /****Recursive method*****/
        public static int factorial(int n){
            if(n==0){
                return 0;
            }else if (n==1){
                return 1;
            }else if(n==2){
                return 2;
            }
            return n * factorial(n-1);
            
        }
    

    }

    public static class ExtensionClass{
        public static bool isPrime(this int n){
            for(int i=1;i<n/2;i++){
                if(n%i == 0){
                    return false;
                }
            }
            return true;
        }
    }
}

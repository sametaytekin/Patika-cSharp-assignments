using System;

namespace Extension_Recursive
{
    class Program
    {
        static void Main(string[] args)
        {
            double sayi=0,sonuc=0;
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
        public static double factorial(double n){
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
        public static bool isPrime(this double n){
            if(n<=1){
                return false;
            }

            for(int i=2;i<Math.Sqrt(n);i++){
                if(n%i == 0)
                  return false;
                
            }
            return true;
        }
    }
}

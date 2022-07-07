using System;

namespace Method_Overload
{
    class Program
    {
        static void Main(string[] args)
        {
            int toplam;
            double a=5.3,b=6.3;
            Console.WriteLine( Carp(5,9));
            Console.WriteLine( Carp(5,9,13));
            Console.WriteLine( Carp(a,b));
            Console.WriteLine( Carp(5,9,out toplam));
        }


        public static int Carp(int a,int b){
            return (a*b);
        }

        public static int Carp(int a,int b, out int c){
            c=a*b;
            return c;
        }

        public static int Carp(int a,int b,int c){
            return (a*b*c);
        }

        public static double Carp(double a,double b){
            return (a*b);

        }
    }

    

}

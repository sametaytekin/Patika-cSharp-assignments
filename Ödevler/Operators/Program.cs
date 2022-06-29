using System;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            double tax=0,tip=0;
            decimal total=0;


            System.Console.WriteLine("Tutarıı giriniz:");
            double meal_cost = Convert.ToDouble(Console.ReadLine().Trim());

            System.Console.WriteLine("Bahşiş miktarını giriniz");
            int tip_percent = Convert.ToInt32(Console.ReadLine().Trim());

            System.Console.WriteLine("Vergi miktarını giriniz");
            int tax_percent = Convert.ToInt32(Console.ReadLine().Trim());
            
            if(tip_percent > 5 && tax_percent > 5 ){
                System.Console.WriteLine("Harikasınız, yine bekleriz");
            }
            
            if( tip_percent ==0 || tax_percent == 0 ){
            System.Console.WriteLine("Bahşiş ve ya vergi sıfır girilemez");
            }



            tax= (tax_percent * meal_cost) / 100;
            tip = (tip_percent * meal_cost) /100;
        
            meal_cost=meal_cost+tax+tip;
        
            total= Convert.ToDecimal(meal_cost);
        
            total = Math.Round(total);
            



        }
    }
}

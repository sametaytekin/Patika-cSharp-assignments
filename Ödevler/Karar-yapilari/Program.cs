using System;

namespace Karar_yapilari
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dt = new DateTime();
            Console.WriteLine("If else yapısı ile");
            /*If-else yapısı*/
             if(dt.DayOfWeek == DayOfWeek.Monday){
                Console.WriteLine("Bugün Pazartesi");
             }else if(dt.DayOfWeek == DayOfWeek.Tuesday){
                Console.WriteLine("Bugün Salı");
             }else if(dt.DayOfWeek == DayOfWeek.Wednesday){
                Console.WriteLine("Bugün Çarşamba");
             }else if( dt.DayOfWeek == DayOfWeek.Thursday){
                Console.WriteLine("Bugün Perşembe");
             }else if( dt.DayOfWeek == DayOfWeek.Friday){
                Console.WriteLine("Bugün Cuma");
             }else if( dt.DayOfWeek == DayOfWeek.Saturday){
                Console.WriteLine("Bugün Cumartesi");
             }else{
                Console.WriteLine("Bugün Pazar");
             }

            Console.WriteLine("Switch yapısı ile");
            /*Switc-Case yapısı*/
            switch (dt.DayOfWeek)
            {
                case DayOfWeek.Monday:
                Console.WriteLine("Bugün Pazartesi");
                break;

                case DayOfWeek.Tuesday:
                Console.WriteLine("Bugün Salı");
                break;

                case DayOfWeek.Wednesday:
                Console.WriteLine("Bugün Çarşamba");
                break;

                case DayOfWeek.Thursday:
                Console.WriteLine("Bugün Perşembe");
                break;

                case DayOfWeek.Friday:
                 Console.WriteLine("Bugün Cuma");
                 break;
                
                case DayOfWeek.Saturday:
                Console.WriteLine("Bugün Cumartesi");
                break;

                case DayOfWeek.Sunday:
                Console.WriteLine("Bugün pazar");
                break;
            }
        }
    }
}

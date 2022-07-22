using System;
namespace Phonebook
{
    public class RehberMenu:Menu{
        public override void NumaraGuncelle()
        {
            Console.WriteLine("Lütfen numarasını güncellemek istediğiniz kişinin adını ve ya soyadını giriniz");
        }

        public override void NumaraSilSor(){
            Console.WriteLine("Lütfen numarasını silmek istediğiniz kişinin adını ve ya soyadını giriniz:");
        }


    }
    
}
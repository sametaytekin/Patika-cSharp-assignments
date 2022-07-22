using System;
using System.Collections.Generic;
using System.Collections;

namespace Phonebook{
    public class PhonebookManager : RehberMenu{

        private string isim;
        private string soyisim;
        private string no;

        private Dictionary<string,string> rehber;

        public Dictionary<string, string> Rehber { get => rehber; set => rehber = value; }
        public string Isim { get => isim; set => isim = value; }
        public string Soyisim { get => soyisim; set => soyisim = value; }
        public string No { get => no; set => no = value; }

        public void Ekle(string ad,string soyad,string no){
            
            Isim = ad;
            Soyisim = soyad;
            No= no;
            string tamIsim = String.Concat(Isim," ",Soyisim);
            Rehber.Add(tamIsim,No);
            Console.WriteLine("Kişi eklendi");
        }

        public void Sil(string ara){
            int silSecim;
            string yeniden;
            KeyValuePair<string,string> kayit = KayitBul(ara);

            if(kayit.Value==null){
                Bulunamadi();
                Console.WriteLine("Silmeyi sonlandırmak için: (1)");
                Console.WriteLine("Yeniden denemek için: (2)");
                try
                {
                    silSecim = Convert.ToInt32( Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("Metin girmeyiniz");
                    throw;
                }
                //Yeniden denemek için
                if(silSecim == 2){
                    NumaraSilSor();
                    try
                    {
                        yeniden = Console.ReadLine().ToString().ToUpper();
                    }
                    catch (System.Exception)
                    {
                        Console.WriteLine("Boş bırakmayınız");
                        throw;
                    }
                    
                    Sil(yeniden);
                }
                //Sonlandırmak için
                if(silSecim ==1 ){
                    Console.WriteLine("Silme işlemi sonlandırıldı");
                }

            }else{
                Console.WriteLine(kayit.Key+" kişi silinmek üzere onaylıyor musunuz?(y/n)");
                string sec = Console.ReadLine().ToString();
                if(sec=="y"){
                    Rehber.Remove(kayit.Key);
                    Console.WriteLine("Kişi Silindi");
                }else if( sec=="n"){
                    Console.WriteLine("Kişi silinmedi");
                }
            }

        }

        public void Guncelle(string ara){
            int secimGuncelle;
            string guncel;
            KeyValuePair<string,string> kayit = KayitBul(ara);

            if(kayit.Value == null){
                Bulunamadi();
                Console.WriteLine("Guncellemeyi sonlandırmak için: (1)");
                Console.WriteLine("Yeniden denemek için: (2)");

                try
                {
                    secimGuncelle = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("Metin girmeyiniz");
                    throw;
                }
                //Yeniden denemek için
                if( secimGuncelle == 2){
                    NumaraGuncelle();
                    try
                    {
                         guncel = Console.ReadLine().ToString().ToUpper();
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Boş bırakmayınız");
                        throw;
                    }
                    Guncelle(guncel);
                }
                //Sonlandırmak için
                if(secimGuncelle == 1){
                    Console.WriteLine("Güncelleme sonlandırıldı");
                }
                
            }else{
                Console.WriteLine(kayit.Key+" kişiyi güncellemek istiyor musunuz?(y/n)");
                string guncelle = Console.ReadLine().ToString();
                if(guncelle=="y"){
                    string tempIsim= kayit.Key.ToString().Trim();

                    Console.WriteLine("Numara giriniz");
                    string yeniNO= Console.ReadLine().ToString();
                    //Bulunan kaydı siliyoruz
                    Rehber.Remove(tempIsim);
                    //Aynı key kullanarak yeni numarayı ekliyoruz
                    Rehber.Add(tempIsim,yeniNO);
                    Console.WriteLine("Güncel kayıt: "+tempIsim+" "+Rehber[tempIsim]);
                }else if(guncelle=="n"){
                    Console.WriteLine("Güncellenmedi");
                }

                              

            }
            
        }

        public void Listele(){
            Console.WriteLine("Telefon Rehberi\n*******************");
            foreach (var item in Rehber)
            {
                string[] kisi = item.Key.Split(' ');
                Console.WriteLine("İsim: {0} \nSoyisim: {1}",kisi[0],kisi[1]);
                Console.WriteLine("Telefon numarası: "+item.Value);
            }

        }

        public void Ara(){
            int araSecim;
            //Konsola menüyü yazdırıyoruz
            NumaraAra();

            try
            {
                araSecim = Convert.ToInt32( Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Metin girmeyiniz");
                throw;
            }

            if(araSecim == 1){
                string temp = Console.ReadLine().ToString().ToUpper();
                foreach (var item in Rehber)
                {
                    if(item.Key.Contains( temp )){
                        string[] kisi = item.Key.Split(' ');
                        Console.WriteLine("İsim: {0} \nSoyisim: {1} \nTelefon Numarası:{2}",kisi[0],kisi[1],item.Value);
                        
                    }
                }
            }

            if(araSecim == 2){
                string tempNo = Console.ReadLine().ToString();
                foreach (var item in Rehber)
                {
                    if(item.Value.Contains( tempNo)){
                        string[] kisi = item.Key.Split(' ');
                        Console.WriteLine("İsim: {0} \nSoyisim: {1} \nTelefon Numarası:{2}",kisi[0],kisi[1],item.Value);
                    }
                }
            }

        }

        //İsim ve ya soy isim Key içinde varsa onu seçiyor
        public KeyValuePair<string,string> KayitBul(string ara){
            foreach (var item in Rehber)
            {
                if(item.Key.Contains(ara)){
                    return item;
                }
            }
            return new KeyValuePair<string, string>(null,null);
        }



    public PhonebookManager(){}

    public PhonebookManager(Dictionary<string,string> dc){
        Rehber = dc;
    }




    }
}
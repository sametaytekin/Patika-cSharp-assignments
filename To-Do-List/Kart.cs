using System.Collections.Generic;

namespace To_Do_List
{
    public class Kart{
        string baslik;
        string icerik;
        
        string atanan_kisi;

        KartBoyutu boyut;

        public string Baslik { get => baslik; set => baslik = value; }
        public string Icerik { get => icerik; set => icerik = value; }
        public string Atanan_kisi { get => atanan_kisi; set => atanan_kisi = value; }
        internal KartBoyutu Boyut { get => boyut; set => boyut = value; }

        
        public Kart(string kartBaslik,string kartIcerik,string kisi,KartBoyutu Boyutu){
            Baslik=kartBaslik;
            Icerik=kartIcerik;
            Atanan_kisi=kisi;
            Boyut= Boyutu;
        }

        public Kart(){}


        
    }
    
}
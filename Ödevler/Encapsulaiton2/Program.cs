using System;

namespace Encapsulaiton2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Ogrenci ayse = new Ogrenci(){
                Isim="Ayşe",
                SoyIsim="Kara",
                OgrenciNo=-25,
                Sinif=9
            };

            Console.WriteLine(ayse.OgrenciNo);
        }
    }

    class Ogrenci{
        private string isim;
        private string soyIsim;
        private int ogrenciNo;
        private int sinif;

        public string Isim { get => isim; set => isim = value; }
        public string SoyIsim { get => soyIsim; set => soyIsim = value; }
        public int OgrenciNo { 
            get {return ogrenciNo;}  
            set { 
                if(value>0)
                ogrenciNo = value;   }}
        public int Sinif { get => sinif; set => sinif = value; }

        public Ogrenci(){}

        public Ogrenci(string isim,string soyİsim,int ogrenciNo,int sinif){
            Isim=isim;
            SoyIsim=soyİsim;
            OgrenciNo=ogrenciNo;
            Sinif=sinif;
        }

        public void SınıfAtlat(){
            this.Sinif = this.Sinif +1;
        }

        public void SinifDusur(){
            this.Sinif= this.Sinif -1;
        }
    }
}

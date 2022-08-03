using System;
using System.Collections.Generic;
namespace To_Do_List
{
    public class Board{
        List<Kart> toDo;
        List<Kart> inProgress;
        List<Kart> done;

        public List<Kart> ToDo { get => toDo; set => toDo = value; }
        public List<Kart> InProgress { get => inProgress; set => inProgress = value; }
        public List<Kart> Done { get => done; set => done = value; }
        

        public void BoardListele(){
            Console.WriteLine("TODO Line \n********");
            if(ToDo != null)
            Listele(ToDo);

            Console.WriteLine("IN PROGRESS Line \n********");
            if(InProgress != null)
            Listele(InProgress);

            Console.WriteLine("DONE Line \n*******");
            if(Done != null)
            Listele(Done);
        }
        public Board(){}

        //Öntanımlıı olarak To Do listesine aktarıyoruz
        public Board(List<Kart> liste){
            ToDo = liste;
            InProgress= new List<Kart>();
            Done=new List<Kart>();
        }

        private void Listele(List<Kart> koleksiyon){            
            foreach (var item in koleksiyon)
            {
                KartGoster(item);
 
                Console.WriteLine("---");

            }
        }

        public void BoardKartEkle(Kart eklenecek){
            ToDo.Add(eklenecek);
        }
        public void listedenSil(string ara,List<Kart> liste,out bool bulunamadi){
            Kart silinecek=null;
            foreach (var item in liste)
            {
                if(String.Equals(ara,item.Baslik)){
                    silinecek=item;
                }else{
                    bulunamadi=true;
                }
            }
            bulunamadi=false;
            liste.Remove(silinecek);
            
        }

        public bool KartSil (string ara){
            bool todoBulunamadi=false,inprogBulunamadi=false,doneBulunamadi=false;
            listedenSil(ara,ToDo,out todoBulunamadi);

            if(InProgress.Count >0){
                 listedenSil(ara,InProgress,out inprogBulunamadi);
            }

            if(Done.Count>0){
                listedenSil(ara,Done,out doneBulunamadi);
            }

   
            if(todoBulunamadi&&inprogBulunamadi&&doneBulunamadi){
                return false;
            }

            return true;

     
        }

        public void BoardKartSil(string ara){
            int silSecim;
            string yeniden;
            if(!KartSil(ara)){
                devamMi();
                try
                {
                    silSecim= Int32.Parse( Console.ReadLine());
                }
                catch (FormatException ex)
                {
                    Console.WriteLine(ex.Message.ToString());
                    throw;
                }

                if( silSecim ==1){
                    Console.WriteLine("Silme işlemi sonlandırıldı");
                }

                if(silSecim==2){

                    Console.WriteLine("Öncelikle silmek istediğiniz kartı seçmeniz gerekiyor.");
                    Console.WriteLine("Lütfen kart başlığı yazınız");
                    
                    yeniden= Console.ReadLine().ToString().ToUpper();
                    BoardKartSil(yeniden);             
                    
                }
            }
            Console.WriteLine("Kart silinmiştir.");
            
        }
        //Kartı 3 listede arıyor, bulamazsa null dönüyor
        public Kart KartBul(string aranan){
            foreach(var item in ToDo){
                if(String.Equals(aranan,item.Baslik)){
                    return item;
                }
            }

            foreach (var item in InProgress)
            {
                if(String.Equals(aranan,item.Baslik)){
                    return item;
                }
            }

            foreach(var item in Done){
                if(String.Equals(aranan,item.Baslik)){
                    return item;
                }
            }

            return null;
        }

        public void BoardKartTasi(string ara){
            Kart tasinacak;
            int tasiSecim;
            string yeniden;
            tasinacak=KartBul(ara);

            if(tasinacak == null){
                devamMi();
                try
                {
                    tasiSecim = Int32.Parse( Console.ReadLine());
                }
                catch (FormatException x)
                {
                    Console.WriteLine(x.Message.ToString());
                    throw;
                } 

                if(tasiSecim == 1){
                    Console.WriteLine("İşlem sonlandırıldı");
                }

                if(tasiSecim == 2){
                    Console.WriteLine("Öncelikle taşımak istediğiniz kartı seçmeniz gerekiyor.");
                    Console.WriteLine("Lütfen kart başlığı yazınız");
                    yeniden = Console.ReadLine().ToUpper();
                    BoardKartTasi(yeniden);
                }
            }else{
                Console.WriteLine("Bulunan Kart Bilgileri\n***********");
                KartGoster(tasinacak);

                Console.WriteLine("Taşımak istediğiniz Line seçiniz:");
                Console.WriteLine("(1) TODO\n(2) IN PROGRESS\n(3) DONE");
                Console.WriteLine("");
                try
                {
                    tasiSecim = Int32.Parse( Console.ReadLine());
                }
                catch (FormatException x)
                {
                    Console.WriteLine(x.Message.ToString());
                    throw;
                }


                switch (tasiSecim)
                {
                    case 1:
                    bool sil1 = KartSil(tasinacak.Baslik);
                    ToDo.Add(tasinacak);
                    BoardListele();

                    break;
                        
                    case 2:
                    bool sil2 = KartSil(tasinacak.Baslik);
                    InProgress.Add(tasinacak);
                    BoardListele();

                    break;
                        
                    case 3:
                    bool sil3 = KartSil(tasinacak.Baslik);
                    Done.Add(tasinacak);

                    BoardListele();

                    break;

                    default:
                    Console.WriteLine("Yanlış bir seçim yaptınız");
                    break;
                        
                    }
                

            }
            
            

            
        }

        public void devamMi(){
                Console.WriteLine("Aradığınız kriterlere göre kart bulunamadı. Lütfen bir seçim yapınız");
                Console.WriteLine("İşlemi sonlandırmak için (1)");
                Console.WriteLine("Yeniden denemek için (2)");
        }

        public void KartGoster(Kart goster){
                Console.WriteLine("Başlık".PadRight(15)+":"+goster.Baslik);
                Console.WriteLine("İçerik".PadRight(15)+":"+goster.Icerik);
                Console.WriteLine("Atanan Kişi".PadRight(15)+":"+goster.Atanan_kisi);
                Console.WriteLine("Kart Boyutu".PadRight(15)+":"+goster.Boyut);
        }

 




    }
    
}
using System;
using System.Collections;
using System.Collections.Generic;

namespace arList
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList diziListe = new ArrayList();
            diziListe.Add(25);
            diziListe.Add(4345.6);
            diziListe.Add(true);
            diziListe.Add("Kurak");
            diziListe.Add('d');

            foreach (var item in diziListe)
            {
                Console.WriteLine(item);
            }
            diziListe.RemoveRange(0,5);
            Console.WriteLine("*********");
            string[] mevsimler = {"Yaz","Sonbahar","Kış","İlkbahar"};
            List<int> sayilar = new List<int>(){323,53,664,6,23,88};

            diziListe.AddRange(mevsimler);
            diziListe.AddRange(sayilar);

            foreach(var item in diziListe){
                Console.WriteLine(item);
            }

        }
    }
}

using System;
using System.Collections.Generic;

namespace Collections
{

    // Collections: .Net Framework'unde cesitli class icin ilgili objelerin
    // bir arada tutulmasini saglayan yapilardir.
    // Bu yapilar icin verilerin nasil saklandigini bilmemize gerek yoktur
    // int[] arr = new int[5] -> Boyutlu bir array olusturduk

    // Collections -> veri sakadigimiz yapilarin boyutlari dinamik olarak degisir
    // En onemli iki ornegi:
    // 1. List : Bizim tanimlamis oldugumuz array yapisina oldukca benzer
    //           Generic bir yapidir. Istedigimiz veri turunde veri saklamaya olanak saglar.
    //           Kullanmak icin System.Collections.Generic namespace inin import aedilmesi gerekir
    // 2. Dictionary(Sözlük) : Ayni sozluk gibi calismasindan oturu dictionary denmistir
    //                         Key - Value Pair (Anahtar-Deger) ikilisinden olusur. 
    //                         Key kismi sozlukteki kelime kismina denk dusunulebilir
    //                         Value kismi da anlam kismina denk dusunulebilir


    class Program
    {
        static void DisplayList<T>(List<T> items)
        {
            foreach(var item in items)
            {
                Console.WriteLine(item.ToString());
            }
        }

        static void Main(string[] args)
        {
            // -------------------------------- Collections --------------------------------
            var items = new List<string>();

            Console.WriteLine($"List Count: {items.Count}, Capacity: {items.Capacity}");

            items.Add("kirmizi");
            items.Add("beyaz");
            items.Add("pembe");
            items.Insert(0, "ramazan");
            items.Add("osman");

            Console.WriteLine($"List Count: {items.Count}, Capacity: {items.Capacity}");
            DisplayList(items);

            // -------------------------------- Dictionary --------------------------------
            Dictionary<int, string> dict = new Dictionary<int, string>();
            dict.Add(21, "Ahmet");
            dict.Add(32, "Osman");
            dict.Add(100, "Ramazan");

            foreach(KeyValuePair<int, string> item in dict)
            {
                Console.WriteLine($"Key: {item.Key}, Value: {item.Value}");
            }

            Console.WriteLine(dict[32]); // key
            Console.WriteLine(items[1]); // index

            Console.ReadKey();
        }
    }
}

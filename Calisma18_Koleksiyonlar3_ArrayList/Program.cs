using System;
using System.Collections;
using System.Collections.Generic;

namespace Calisma18_Koleksiyonlar3_ArrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            //System.Collection namespace

            ArrayList liste = new ArrayList();
            // liste.Add("Ayşe");
            // liste.Add(21);
            // liste.Add(true);
            // liste.Add('A');

            //içerisinde verilere erişim
            // Console.WriteLine(liste[1]);
            // foreach(var item in liste)
            // {
            //     Console.WriteLine(item);
            // }

            // Add Range
            Console.WriteLine("*********Add Range********");
            //string[] renkler ={"Kırmızı","Sarı","Yeşil"};
            List<int> sayılar = new List<int>(){1,8,3,7,9,5};
            //liste.AddRange(renkler);
            liste.AddRange(sayılar);
            foreach(var item in liste)
            {
                Console.WriteLine(item);
            }

            //Sort
            Console.WriteLine("********Sort********");
            liste.Sort();
            foreach(var item in liste)
            {
                Console.WriteLine(item);
            }

            //Binary Search  (Bunu kullanmak için öncelikle sort metodunu kullanmamız gerekmekte)
            Console.WriteLine("*******Binary Searc****");
            Console.WriteLine(liste.BinarySearch(9));

            //Reverse   (Aynalama)
            Console.WriteLine("********Reverse******");
            liste.Reverse();
            foreach(var item in liste)
            {
                Console.WriteLine(item);
            }

            // Clear
            Console.WriteLine("********Clear******");
            liste.Clear();
            foreach(var item in liste)
            {
                Console.WriteLine(item);
            }




        }
    }
}

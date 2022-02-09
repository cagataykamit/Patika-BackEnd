using System;
using System.Collections.Generic;
using System.Linq;

namespace Calisma15_C_101_Odev1
{
    class Program
    {
        static void Main(string[] args)
        {
            //*********1. Sorunun çözümü burada başlar*************
            Console.WriteLine("******1. Soru*******");
            Console.WriteLine("Pozitif bir tamsayi giriniz");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(n + " Adet pozitif tamsayi giriniz");
            int[] dizi1 = new int[n];
            for(int i=0;i<n;i++)
            {
                dizi1[i]=Convert.ToInt32(Console.ReadLine());
            }
            for(int i=0; i<n; i++)
            {
                if(dizi1[i]%2==0)
                {
                    Console.WriteLine(i + " nolu dizi indisi = " + dizi1[i]);
                }
            }
            //********1.sorunun çözümü burada biter************

            //********2.Sorunun çözümü burada başlar***********
            Console.WriteLine("******2. Soru*******");
            Console.WriteLine("Pozitif tamsayi giriniz(Sayi Adedi)");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Pozitif tamsayi giriniz(Bölen)");
            int m = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(n1 + " adet tamsayi giriniz");
            int[] dizi2 = new int[n1];
            for (int i = 0; i < n1; i++)
            {
                dizi2[i] = Convert.ToInt32(Console.ReadLine());   
            }
            Console.WriteLine(m + " sayisina tam bölünenler ");
            for (int i = 0; i < n1; i++)
            {
                if (dizi2[i] % m == 0)
                {
                    Console.WriteLine(dizi2[i]);
                }
            }
            //*******2.Sorunun Çözümü Burada Bitiyor***********

            //*******3.Sorunun Çözümü Burada Başlıyor**********
            Console.WriteLine("******3. Soru*******");
            Console.WriteLine("Bir tam sayi giriniz(n2)");
            int n2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(n2 + " adet kelime giriniz");
            string[] kelimeDizisi = new string[n2];
            for(int i=0; i<n2; i ++)
            {
                kelimeDizisi[i] = Console.ReadLine();
            }
            Array.Reverse(kelimeDizisi);

            foreach(string item in kelimeDizisi)
            {
                Console.WriteLine(item);
            }
            //*******3. Sorunun Cevabı Burada Bitiyor*******
            //*******4. Sorunun Cevabu Burada Başlıyor******
                Console.WriteLine("Bir cümle giriniz");
                string yazi = Console.ReadLine();
                List<string> kelimeler = yazi.Split(" ").ToList();
                kelimeler.RemoveAll( a => a =="");
                int sayac=0;
                foreach(string kelime in kelimeler)
                {
                    sayac++;
                    Console.WriteLine(kelime);
                }
                Console.WriteLine("Kelime sayisi : " + sayac);
                Console.WriteLine("Bir cümle giriniz");
                harfSay(Console.ReadLine());
                Console.ReadKey();     
        }
        private static void harfSay(string cumle)
        {
            if (!string.IsNullOrWhiteSpace(cumle))
            {
              int sayac = cumle.Length;
              string harf = cumle.Substring(0, 1);
              cumle = cumle.Replace(harf, "");
              sayac -= cumle.Length;
              Console.WriteLine($"{harf} -> {sayac} Adet");
              harfSay(cumle);
            }
        }
    }
}


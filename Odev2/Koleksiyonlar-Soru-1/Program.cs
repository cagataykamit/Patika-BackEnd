using System;
using System.Collections.Generic;

namespace Koleksiyonlar_Soru_1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> sayilar = new List<int>();
            List<int> asalSayilar = null;
            List<int> asalOlmayanSayilar = null;
            Console.WriteLine("20 Adet Sayı giriniz");
            for (int i = 1; i <= 20; i++)
            {
                string deger = Console.ReadLine();
                int sayi = 0;
                bool sayiMi = Int32.TryParse(deger, out sayi);

                if (!sayiMi || NegatifMi(deger, sayiMi))
                {
                    Console.WriteLine("Sayi girmelisiniz, yeniden giriniz");
                    asalOlmayanSayilar=new List<int>();
                    i--;
                    i--;
                }
                else
                    sayilar.Add(Convert.ToInt32(deger));
            }
            asalSayilar = new List<int>();
            asalOlmayanSayilar = new List<int>();

            foreach (int item in sayilar)
            {
                if (AsalMi(item))
                {
                    asalSayilar.Add(item);
                }
                else
                {
                    asalOlmayanSayilar.Add(item);
                }
            }
            Console.WriteLine("Asal Sayılar: ");
            foreach(int item in asalSayilar)
            Console.WriteLine(item);
            Console.WriteLine("Asal Olmayan Sayılar: ");
            foreach(int item in asalOlmayanSayilar)
            Console.WriteLine(item);
        }
        public static bool NegatifMi(string sayi, bool sayiMi)
        {
            return sayiMi && Convert.ToInt32(sayi) < 0;
        }
        public static bool AsalMi(int sayi)
        {
            bool sonuc = false;
            int sayac = 0;
            if (sayi == 1)
                return sonuc;
            for (int i = 2; i <= (Convert.ToInt32(sayi) / 2); i++)
            {
                if (Convert.ToInt32(sayi) % i == 0)
                {
                    sayac++;
                }
            }
            if (sayac == 0)
            {
                sonuc = true;
            }
            return sonuc;
        }
    }
}

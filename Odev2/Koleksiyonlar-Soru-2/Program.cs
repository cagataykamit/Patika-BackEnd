using System;

namespace Koleksiyonlar_Soru_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("20 adet sayı giriniz");
            int[] sayilar = new int[20];
            for(int i=0;i<20;i++)
            {
                sayilar[i] = Convert.ToInt32(Console.ReadLine());
            }
            Array.Sort(sayilar);
            Console.WriteLine("En küçük 3 üç sayi " + sayilar[0] + " , " + sayilar[1] + " , " + sayilar[2] + "'dir.");
            double ort1 = (sayilar[0] + sayilar[1] + sayilar[2])/3;
            Array.Reverse(sayilar);
            Console.WriteLine("En büyük 3 üç sayi " + sayilar[0] + " , " + sayilar[1] + " , " + sayilar[2] + "'dir.");

            double ort2 = (sayilar[0] + sayilar[1] + sayilar[2])/3;
            double ortToplam= ort1 + ort2;
            Console.WriteLine("En küçük üç sayının ortalaması =  " + ort1 +"'dir" );
            Console.WriteLine("En büçük üç sayının ortalaması =  " + ort2 +"'dir" );
            Console.WriteLine("Ortalamaların Toplamı = " + ortToplam + "'dir");
        }
    }
}
//TryParseKoy
//Ortalama Metodu Koy
using System;

namespace Calisma13_Metod_Overloading
{
    class Program
    {
        static void Main(string[] args)
        {
            //out parametreler
            string sayi ="999";
            
            bool sonuc= int.TryParse(sayi,out int outSayi);
            if(sonuc == true)
            {
                Console.WriteLine("Başarili");
                Console.WriteLine(outSayi);
            }
            else
            {
                Console.WriteLine("Başarisiz");
            }
            Metotlar instance = new Metotlar();
            instance.Topla(2,3,out int toplamSonucu);
            Console.WriteLine(toplamSonucu);

            //Metot Aşırı Yükleme - Overloading
            int ifade=999;
            instance.EkranaYazdir(ifade);
            instance.EkranaYazdir("Çağatay " + "Kamit");

            //Metot İmzası
            //metotadi + parametre sayisi + parametre
        }
    }
    class Metotlar
    {
        public void Topla(int a,int b, out int toplam)
        {

            toplam = a+b;
        }

        public void EkranaYazdir(string veri)
        {
            Console.WriteLine(veri);
        }

        public void EkranaYazdir(int veri)
        {
            Console.WriteLine(veri);
        }

        public void EkranaYazdir(string veri1,string veri2)
        {
            Console.WriteLine(veri1+veri2);
        }

    }
}

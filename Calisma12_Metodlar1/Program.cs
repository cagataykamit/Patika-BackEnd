using System;

namespace Calisma12_Metodlar1
{
    class Program
    {
        static void Main(string[] args)
        {
            //erisim_belirteci geri_donustipi metot_adi(parametreListesi/arguman)
            //{
                // komutlar;
            //}
            int a =2;
            int b =3;
            int toplam = Topla(a,b);
            Console.WriteLine(toplam);

            Metotlar ornek = new Metotlar();
            ornek.EkranaYazdir(Convert.ToString(toplam));
            
            
            int sonuc2 =ornek.ArttirveTopla(ref a,ref b);
            ornek.EkranaYazdir(Convert.ToString(sonuc2));
            ornek.EkranaYazdir(Convert.ToString(a+b));
        }
            static int Topla(int deger1,int deger2)
            {
                return deger1+deger2;
            }
    }
    class Metotlar
    {
        public void EkranaYazdir(string veri)
        {
            Console.WriteLine(veri);
        }
        public int ArttirveTopla(ref int deger1,ref int deger2)
        {
            deger1 +=1;
            deger2 +=1;
            return deger1+deger2;
        }
    }
}


using System;

namespace Clisma21_ErişimBelirleyiciler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("********Calisan1******");
            Calisan calisan1 = new Calisan("Ayşe","Kara",23415634,"İnsan Kaynakları");
            calisan1.CalisanBilgileri();
            Console.WriteLine("*****Calisan2*****");
            Calisan calisan2=new Calisan();
            calisan2.Ad="Deniz";
            calisan2.Soyad="Arda";
            calisan2.No= 25646789 ;
            calisan2.Departman= "Satın Alma";
            calisan2.CalisanBilgileri();
            Console.WriteLine("******Calisan3*****");
            Calisan calisan3 = new Calisan("Cagatay","Kamit");
            calisan3.CalisanBilgileri();
        }
    }
    class Calisan
    {
        public string Ad;
        public string Soyad;
        public int No;
        public string Departman;

        public Calisan(){}

        public Calisan(string ad,string soyad,int no,string departman)
        {
            Ad=ad;
            Soyad=soyad;
            No=no;
            Departman=departman;
        }

        public Calisan(string ad,string soyad)
        {
            Ad=ad;
            Soyad=soyad;
        }
        public void CalisanBilgileri()
        {
            Console.WriteLine("Çalışan adı : {0}",Ad);
            Console.WriteLine("Çalışan soyadı : {0} ",Soyad);
            Console.WriteLine("Çalışanın Numarası : {0} ",No);
            Console.WriteLine("Çalışanın Depertmanı : {0} ",Departman);
        }
    }
}

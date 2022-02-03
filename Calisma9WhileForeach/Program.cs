using System;

namespace Calisma9WhileForeach
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen bir sayi giriniz");
            int sayi = int.Parse(Console.ReadLine());
            int sayac =1;
            int toplam = 0;
            while(sayac<=sayi)
            {
                toplam+=sayac;
                sayac++;
            }
            Console.WriteLine(toplam/sayi);


            char character='a';
            while(character < 'z')
            {
                Console.Write(character);
                character++;
            }
            Console.Write("Foreach**** ");
            string[] arabalar = {" BMW","FORD","TOYOTA","NİSSAN"};
            foreach(var araba in arabalar)
            {
                Console.WriteLine(araba);
            }
        }
    }
}

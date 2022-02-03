using System;

namespace Calisma8_forloop_break_continue
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen Bir Sayı Griniz");
            int sayac = int.Parse(Console.ReadLine());
            for(int i=1;i<=sayac;i++)
            {
                if(i%2 == 1)
                Console.WriteLine(i);
            }

            int tekToplam = 0;
            int ciftToplam= 0;
            for(int i=1; i <=1000;i++)
            {

                if(i%2 ==1)
                tekToplam+=1;
                else
                ciftToplam+=1;
            }
            Console.WriteLine("Tek Toplam " + tekToplam );
            Console.WriteLine("Çift Toplam" + ciftToplam);

            for(int i =1;i<10;i++)
            {
                if(i==4)
                break;
                Console.WriteLine(i);
            }
            for(int i =1;i<10;i++)
            {
                if(i==4)
                continue;
                Console.WriteLine(i);
            }
            
        }
    }
}

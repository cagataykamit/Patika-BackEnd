using System;

namespace Calisma6
{
    class Program
    {
        static void Main(string[] args)
        {
            int time = DateTime.Now.Hour;

            if(time >=6 && time <11)
            {
                Console.WriteLine("Günaydın1");
            }
            else if(time <=18)
            Console.WriteLine("İyi Günler1");
            else
            Console.WriteLine("iyi Geceler1");

            string sonuc = time<=18 ?"İyi günler2" : "İyi geceler2";
            Console.WriteLine(sonuc);

            sonuc = time>=6 && time <=11 ? "Günaydın3" : time<=18 ? "İyi günler3" : "İyi geceler3";
            Console.WriteLine(sonuc);
            
        }
    }
}

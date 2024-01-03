using System.ComponentModel.Design;
using System.Net;

namespace MyOwnWorks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int rastgelesayi = rnd.Next(10, 30);
            Console.WriteLine("Üretilen sayı:{0}", rastgelesayi);
            int hak = 3;
        BASADON:
            Console.Write("Bir tahminde bulununuz:");
            int tahmin = Convert.ToInt32(Console.ReadLine());
            if (tahmin == rastgelesayi)
            {
                Console.Write("Tebrikler... Puan:{0}", hak * 10);
            }
            else if (tahmin < rastgelesayi)
            {
                hak--;
                if (hak == 0)
                {
                    Console.Write("kaybettiniz. hakkınız kalmadı.");
                }
                else
                {
                    Console.Write("Tahmininizi büyültünüz.");
                    goto BASADON;
                }
            }
            else if (tahmin > rastgelesayi)
            {
                hak--;
                if (hak == 0)
                {
                    Console.Write("Kaybettiniz. Hakkınız kalmadı.");
                }
                else
                {
                    Console.Write("Tahmininizi küçültünüz.");
                    goto BASADON;
                }
            }
            Console.ReadKey();


        }
    }
}
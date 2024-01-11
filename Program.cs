using System.ComponentModel.Design;
using System.Net;

namespace MyOwnWorks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            
            
            
            
            
            
            // ÖDEV
 Console.WriteLine("Kaç tane sayı sıralamak istiyorsunuz?");
 int count = int.Parse(Console.ReadLine());
 Console.WriteLine("Başlangıç numarası giriniz:");
 int start = int.Parse(Console.ReadLine());
 Console.WriteLine("Bitiş numarası giriniz:");
 int end = int.Parse(Console.ReadLine());
 Console.WriteLine("Rastgele sayılar oluşturuldu:");

 Random rnd = new Random();
 int[] numbers = new int[count];

 for (int i = 0; i < numbers.Length; i++)
 {
     int number;
     bool unique;//sayıların benzersiz olup olmadığını kontrol eder.
     do
     {
         number = rnd.Next(start, end);
         unique = true; // atanan sayıların benzersizliğini doğrular.
         for (int j = 0; j < i; j++)// daha önce üretilen sayıları karşılaştırmak için
         {
             if (numbers[j] == number)
             {
                 unique = false;
                 break;
             }
         }
     } while (!unique);
     numbers[i] = number;
 }
 Array.Sort(numbers);
 Console.WriteLine("Sıralı sayıları yazdır:");
 for (int i = 0; i < numbers.Length; i++)
 {
     Console.WriteLine(numbers[i]);
 }









































            

            
               
            
            
            
            









            
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

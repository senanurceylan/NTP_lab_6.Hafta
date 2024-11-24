using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.H_Overloading_1
{
    class Program
    {
        // İlk sürüm: İki tam sayıyı toplar
        static int Topla(int a, int b)
        {
            
            // Açıklama: a ve b değişkenlerini toplar ve sonucu döndürür.
            return a + b;
        }
        // İkinci sürüm: Üç tam sayıyı toplar
        static int Topla (int a, int b, int c)
        {
            // Açıklama: Dizinin tüm elemanlarını toplar.
            return a + b + c;
        }

        static int Topla(int[] Sayilar)
        {
            int toplam = 0;
            foreach(int sayi in Sayilar)
            {
                toplam += sayi;
            }
            return toplam;
        }
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] Sayilar = new int[5];
            for(int i=0; i< Sayilar.Length; i++)
            {
                Sayilar[i] = rnd.Next(1, 10);
            }
            foreach(int x in Sayilar)
            {
                Console.WriteLine(x);
            }
           
            Console.WriteLine("İki sayının toplamı: " + Topla(3, 5));
            Console.WriteLine("Üç sayının toplamı: " + Topla(3, 5, 7));
            Console.WriteLine("Dizinin elemanlarının toplamı: " + Topla(Sayilar));
            Console.ReadLine();
        }
    }
}

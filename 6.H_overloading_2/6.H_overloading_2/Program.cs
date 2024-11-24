using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.H_overloading_2
{
    class Program
    {
        static int AlanHesapla(int kenar)
        {
          return kenar * kenar;
        }
        static int AlanHesapla(int uzunKenar ,int kisaKenar)
        {
            return uzunKenar * kisaKenar;
        }
        static double AlanHesapla(double yaricap)
        {
            return Math.PI* yaricap * yaricap;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("karenin Alanı"+AlanHesapla(4));
            Console.WriteLine("dikdörtgenin Alanı"+ AlanHesapla(5,3));
            Console.WriteLine("dairenin Alanı"+ AlanHesapla(2,5));
            Console.ReadLine();
        }
    }
}

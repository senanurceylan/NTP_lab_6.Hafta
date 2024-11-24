using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.H_Overloading_3
{
    class Program
    {

        static int TarihFarki(DateTime tarih1, DateTime tarih2)
        {
            return (tarih2 - tarih1).Days;
        }

        static double TarihFarkiSaat(DateTime tarih1, DateTime tarih2)
        {
            // Açıklama: Tarihler arasındaki farkı saat cinsinden hesaplar.
            return (tarih2 - tarih1).TotalHours;
        }

        // Üçüncü sürüm: Gün ve saat farkını ayrı ayrı döndürür (Tuple kullanılarak)
        static Tuple<int, double> TarihFarkiDetayli(DateTime tarih1, DateTime tarih2)
        {
            // Açıklama: Gün ve saat farkını bir Tuple olarak döndürür.
            TimeSpan fark = tarih2 - tarih1;
            return Tuple.Create(fark.Days, fark.TotalHours);
        }

        static void Main()
        {
            DateTime tarih1 = new DateTime(2023, 11, 1);
            DateTime tarih2 = new DateTime(2023, 11, 24);

            // Test: Gün farkı
            Console.WriteLine("Gün farkı: " + TarihFarki(tarih1, tarih2));

            // Test: Saat farkı
            Console.WriteLine("Saat farkı: " + TarihFarkiSaat(tarih1, tarih2));

            // Test: Detaylı fark
            var fark = TarihFarkiDetayli(tarih1, tarih2);
            Console.WriteLine($"Gün farkı: {fark.Item1}, Saat farkı: {fark.Item2}");
            Console.ReadLine();
        }
    
    }
}
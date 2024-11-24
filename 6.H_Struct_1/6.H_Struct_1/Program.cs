using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.H_Struct_1
{
    struct Time
    {
        public int Hour { get; set; }
        public int Minute { get; set; }

        // Yapıcı metot
        public Time(int hour, int minute)
        {
            Hour = hour < 0 || hour > 23 ? 0 : hour;
            Minute = minute < 0 || minute > 59 ? 0 : minute;
        }

        // Toplam dakika hesaplama metodu
        public int TotalMinutes()
        {
            return (Hour * 60) + Minute;
        }

        // İki zaman arasındaki dakika farkı
        public static int DifferenceInMinutes(Time t1, Time t2)
        {
            return Math.Abs(t2.TotalMinutes() - t1.TotalMinutes());
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Time time1 = new Time(14, 30); // 14:30
            Time time2 = new Time(16, 45); // 16:45

            Console.WriteLine($"Time1 toplam dakika: {time1.TotalMinutes()}"); // 870
            Console.WriteLine($"Time2 toplam dakika: {time2.TotalMinutes()}"); // 1005
            Console.WriteLine($"İki zaman arasındaki fark: {Time.DifferenceInMinutes(time1, time2)} dakika"); // 135
            Console.ReadLine();
        }
    }
}
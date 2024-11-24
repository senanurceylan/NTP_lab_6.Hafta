using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.H_Struct_3
{
    struct GPS
    {
        public double Latitude { get; set; }
        public double Longitude { get; set; }

        // Yapıcı metot
        public GPS(double latitude, double longitude)
        {
            Latitude = latitude;
            Longitude = longitude;
        }

        // Haversine formülü ile mesafe hesaplama
        public static double Distance(GPS point1, GPS point2)
        {
            const double R = 6371; // Dünya'nın yarıçapı (km)

            double dLat = ToRadians(point2.Latitude - point1.Latitude);
            double dLon = ToRadians(point2.Longitude - point1.Longitude);

            double a = Math.Sin(dLat / 2) * Math.Sin(dLat / 2) +
                       Math.Cos(ToRadians(point1.Latitude)) * Math.Cos(ToRadians(point2.Latitude)) *
                       Math.Sin(dLon / 2) * Math.Sin(dLon / 2);

            double c = 2 * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1 - a));
            return R * c; // Mesafe (km)
        }

        private static double ToRadians(double degrees)
        {
            return degrees * Math.PI / 180;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            GPS point1 = new GPS(41.0082, 28.9784); // İstanbul
            GPS point2 = new GPS(39.9208, 32.8541); // Ankara

            Console.WriteLine($"İki nokta arasındaki mesafe: {GPS.Distance(point1, point2):F2} km");
            Console.ReadLine();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.H_indexleyiciler_3
{
    class ParkingLot
    {
        private string[,] parkingSpots = new string[3, 5]; // 3 kat, her katta 5 park yeri

        // İndeksleyici tanımı
        public string this[int floor, int spot]
        {
            get
            {
                if (floor < 0 || floor >= 3 || spot < 0 || spot >= 5)
                    return "Hata: Geçersiz park yeri!";
                return parkingSpots[floor, spot] ?? "Empty"; // Park yeri boşsa "Empty" döner.
            }
            set
            {
                if (floor < 0 || floor >= 3 || spot < 0 || spot >= 5)
                    Console.WriteLine("Hata: Geçersiz park yeri!");
                else
                    parkingSpots[floor, spot] = value; // Park yerini günceller.
            }
        }
    }

    class sena
    {
        static void Main()
        {
            ParkingLot parkingLot = new ParkingLot();

            // Park yerlerini ayarlama
            parkingLot[0, 0] = "34AB123"; // 1. katta 1. park yerine araç yerleştiriliyor.
            parkingLot[1, 2] = "06CD456";

            // Park yerlerini kontrol etme
            Console.WriteLine(parkingLot[0, 0]); // Çıktı: 34AB123
            Console.WriteLine(parkingLot[1, 1]); // Çıktı: Empty
            Console.WriteLine(parkingLot[3, 5]); // Çıktı: Hata: Geçersiz park yeri!
            Console.ReadLine();
        }
    }
}
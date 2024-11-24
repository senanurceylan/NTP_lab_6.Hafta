using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.H_indexleyiciler_2
{
    class Program
    {

        private string[,] board = new string[8, 8]; // 8x8 satranç tahtası

        // İndeksleyici tanımı
        public string this[int row, int col]
        {
            get
            {
                if (row < 0 || row >= 8 || col < 0 || col >= 8)
                    return "Hata: Geçersiz kare!"; // Geçersiz kare için hata mesajı
                return board[row, col] ?? "Boş"; // Kare boşsa "Boş" döner.
            }
            set
            {
                if (row < 0 || row >= 8 || col < 0 || col >= 8)
                    Console.WriteLine("Hata: Geçersiz kare!");
                else
                    board[row, col] = value; // Kareye taş eklenir.
            }
        }
    }

    class Sena
    {
        static void Main()
        {
            Program chessBoard = new Program();

            // Taş ekleme
            chessBoard[0, 0] = "Kale";
            chessBoard[0, 1] = "At";

            // Taşlara erişim
            Console.WriteLine(chessBoard[0, 0]); // Çıktı: Kale
            Console.WriteLine(chessBoard[7, 7]); // Çıktı: Boş
            Console.WriteLine(chessBoard[8, 8]); // Çıktı: Hata: Geçersiz kare!
            Console.ReadLine();
        }
    }
}
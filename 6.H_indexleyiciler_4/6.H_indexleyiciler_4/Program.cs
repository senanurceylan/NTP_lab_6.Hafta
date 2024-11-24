using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.H_indexleyiciler_4
{
    class Library
    {
        private string[] books = new string[5]; // 5 kitaplık bir koleksiyon oluşturuluyor.

        // İndeksleyici tanımı
        public string this[int index]
        {
            get
            {
                if (index < 0 || index >= books.Length)
                    return "Hata: Geçersiz indeks!"; // Geçersiz indeks için hata mesajı
                return books[index] ?? "Boş"; // Kitap yoksa "Boş" döner.
            }
            set
            {
                if (index < 0 || index >= books.Length)
                    Console.WriteLine("Hata: Geçersiz indeks!"); // Geçersiz indeks uyarısı
                else
                    books[index] = value; // Kitap adını güncelle
            }
        }
    }

    class Program
    {
        static void Main()
        {
            Library library = new Library();

            // Kitap ekleme
            library[0] = "Sefiller";
            library[1] = "Suç ve Ceza";

            // Kitaplara erişim
            Console.WriteLine(library[0]); // Çıktı: Sefiller
            Console.WriteLine(library[1]); // Çıktı: Suç ve Ceza
            Console.WriteLine(library[4]); // Çıktı: Boş
            Console.WriteLine(library[5]); // Çıktı: Hata: Geçersiz indeks!
            Console.ReadLine();
        }
    }
}
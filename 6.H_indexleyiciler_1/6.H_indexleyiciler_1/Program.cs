using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.H_indexleyiciler_1
{
    class Program
    {
        private Dictionary<string, int> grades = new Dictionary<string, int>();

        // İndeksleyici tanımı
        public int this[string course]
        {
            get
            {
                if (!grades.ContainsKey(course))
                {
                    Console.WriteLine("Hata: Ders bulunamadı!");
                    return -1; // Hata durumunda -1 döner.
                }
                return grades[course]; // Ders notunu döner.
            }
            set
            {
                grades[course] = value; // Ders notunu ayarlar.
            }
        }
    }

    class Sena
    {
        static void Main()
        {
            Program student = new Program();

            // Derslere not ekleme
            student["Matematik"] = 95;
            student["Fizik"] = 85;

            // Ders notlarına erişim
            Console.WriteLine("Matematik: " + student["Matematik"]); // Çıktı: Matematik: 95
            Console.WriteLine("Kimya: " + student["Kimya"]); // Çıktı: Hata: Ders bulunamadı!
            Console.ReadLine();
        }
    }
}
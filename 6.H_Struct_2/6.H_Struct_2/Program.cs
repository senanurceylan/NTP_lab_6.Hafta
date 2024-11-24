using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.H_Struct_2
{
    struct Complex
    {
        public double Real { get; set; }
        public double Imaginary { get; set; }

        // Yapıcı metot
        public Complex(double real, double imaginary)
        {
            Real = real;
            Imaginary = imaginary;
        }

        // Toplama işlemi
        public static Complex Add(Complex c1, Complex c2)
        {
            return new Complex(c1.Real + c2.Real, c1.Imaginary + c2.Imaginary);
        }

        // Çıkarma işlemi
        public static Complex Subtract(Complex c1, Complex c2)
        {
            return new Complex(c1.Real - c2.Real, c1.Imaginary - c2.Imaginary);
        }

        // ToString metodu
        public override string ToString()
        {
            return $"{Real} + {Imaginary}i";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Complex c1 = new Complex(3, 4); // 3 + 4i
            Complex c2 = new Complex(1, 2); // 1 + 2i

            Complex sum = Complex.Add(c1, c2);
            Complex diff = Complex.Subtract(c1, c2);

            Console.WriteLine($"Toplam: {sum}"); // 4 + 6i
            Console.WriteLine($"Fark: {diff}"); // 2 + 2i
            Console.ReadLine();
        }
    }
}
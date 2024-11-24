using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.H_Enum_3
{
    enum EmployeeRole
    {
        Manager,
        Developer,
        Designer,
        Tester
    }

    class SalaryCalculator
    {
        public int GetSalary(EmployeeRole role)
        {
            switch (role)
            {
                case EmployeeRole.Manager:
                    return 15000; // Manager maaşı
                case EmployeeRole.Developer:
                    return 12000; // Developer maaşı
                case EmployeeRole.Designer:
                    return 10000; // Designer maaşı
                case EmployeeRole.Tester:
                    return 8000; // Tester maaşı
                default:
                    return 0;
            }
        }
    }

    class Program
    {
        static void Main()
        {
            SalaryCalculator calculator = new SalaryCalculator();
            Console.WriteLine("Manager maaşı: " + calculator.GetSalary(EmployeeRole.Manager));    // Çıktı: 15000
            Console.WriteLine("Developer maaşı: " + calculator.GetSalary(EmployeeRole.Developer)); // Çıktı: 12000
            Console.ReadLine();
        }
    }
}
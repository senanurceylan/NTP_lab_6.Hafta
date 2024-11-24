using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.H_Enum_1
{
    enum TrafficLight
    {
        Red,
        Yellow,
        Green
    }

    class TrafficControl
    {
        public string GetAction(TrafficLight light)
        {
            switch (light)
            {
                case TrafficLight.Red:
                    return "Dur!";
                case TrafficLight.Yellow:
                    return "Hazırlan!";
                case TrafficLight.Green:
                    return "Geç!";
                default:
                    return "Bilinmeyen durum.";
            }
        }
    }

    class Program
    {
        static void Main()
        {
            TrafficControl control = new TrafficControl();
            Console.WriteLine(control.GetAction(TrafficLight.Red));     // Çıktı: Dur!
            Console.WriteLine(control.GetAction(TrafficLight.Yellow));  // Çıktı: Hazırlan!
            Console.WriteLine(control.GetAction(TrafficLight.Green));   // Çıktı: Geç!
            Console.ReadLine();
        }
    }
}
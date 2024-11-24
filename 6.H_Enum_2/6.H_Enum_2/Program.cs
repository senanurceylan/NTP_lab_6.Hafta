using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.H_Enum_2
{
    enum Weather
    {
        Sunny,
        Rainy,
        Cloudy,
        Stormy
    }

    class WeatherAdvisor
    {
        public string GetAdvice(Weather weather)
        {
            switch (weather)
            {
                case Weather.Sunny:
                    return "Güneş gözlüğü takın!";
                case Weather.Rainy:
                    return "Şemsiye alın!";
                case Weather.Cloudy:
                    return "Hava kapalı, hazırlıklı olun!";
                case Weather.Stormy:
                    return "Dışarı çıkmayın!";
                default:
                    return "Bilinmeyen hava durumu.";
            }
        }
    }

    class Program
    {
        static void Main()
        {
            WeatherAdvisor advisor = new WeatherAdvisor();
            Console.WriteLine(advisor.GetAdvice(Weather.Sunny));  // Çıktı: Güneş gözlüğü takın!
            Console.WriteLine(advisor.GetAdvice(Weather.Rainy));  // Çıktı: Şemsiye alın!
            Console.ReadLine();
        }
    }
}

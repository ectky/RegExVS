using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Weather
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"([A-Z]{2})(\d+\.\d+)([A-Za-z]+)\|";
            string input = Console.ReadLine();
            var forecast = new Dictionary<string, Weather>();

            while (input != "end")
            {
                if (Regex.IsMatch(input, pattern))
                {
                    Match m = Regex.Match(input, pattern);
                    string city = m.Groups[1].Value;
                    string typeOfWthr = m.Groups[3].Value;
                    double avrgT = double.Parse(m.Groups[2].Value);
                    Weather w = new Weather();
                    w.AvrgTemp = avrgT;
                    w.City = city;
                    w.TypeOfWeather = typeOfWthr;
                    if (!forecast.ContainsKey(city))
                    {
                        forecast.Add(city, new Weather());
                    }
                    forecast[city] = w;
                }
                input = Console.ReadLine();
            }

            foreach (var pair in forecast.OrderBy(p => p.Value.AvrgTemp))
            {
                Console.WriteLine($"{pair.Key} => " +
                    $"{pair.Value.AvrgTemp:F2} => {pair.Value.TypeOfWeather}");
            }
        }
    }

    public class Weather
    {
        public string City { get; set; }
        public double AvrgTemp { get; set; }
        public string TypeOfWeather { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MatchDates
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"([0-9]{2})([.\-\/])([A-Z][a-z]{2})\2([0-9]{4})";
            string input = Console.ReadLine();


            foreach (Match m in Regex.Matches(input, pattern))
            {
                Console.WriteLine($"Day: {m.Groups[1]}, Month: {m.Groups[3]}" +
                    $", Year: {m.Groups[4]}");
            }
        }
    }
}

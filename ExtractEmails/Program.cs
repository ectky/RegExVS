using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ExtractEmails
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(^|(?<=\s))([A-Za-z]+[\.\-_]?\w+)@(\w+[\-\.\w]*\w*)(\.\w+)";
            string input = Console.ReadLine();


            foreach (Match m in Regex.Matches(input, pattern))
            {
                Console.WriteLine(m.Value);
            }
        }
    }
}

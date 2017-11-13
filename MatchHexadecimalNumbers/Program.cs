using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MatchHexadecimalNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\b(0x)?[0-9A-F]+\b";
            string input = Console.ReadLine();


            foreach (Match m in Regex.Matches(input, pattern))
            {
                Console.Write(m.Value + " ");
            }
        }
    }
}

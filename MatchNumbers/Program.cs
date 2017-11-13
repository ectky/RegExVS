using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MatchNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(^|(?<=\s))-?\d+(\.?\d+)?($|(?=\s))";
            string input = Console.ReadLine();


            foreach (Match m in Regex.Matches(input, pattern))
            {
                Console.Write(m.Value + " ");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ExtractSentencesByKeyword
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(^|(?<=\s)).+?($|(?=[.!?]))";
            string word = Console.ReadLine();
            string input = Console.ReadLine();


            foreach (Match m in Regex.Matches(input, pattern))
            {
                
                if (Regex.IsMatch(m.Value, $@"\b{word}\b"))
                {
                    Console.WriteLine(m.Value);
                }
            }
        }
    }
}

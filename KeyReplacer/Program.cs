using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace KeyReplacer
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern1 = @"^([A-Za-z]+)(\<|\|).+?(\<|\|)([A-Za-z]+)$";
            string input = Console.ReadLine();
            Match m = Regex.Match(input, pattern1);
            string key1 = m.Groups[1].Value;
            string key2 = m.Groups[4].Value;
            string pattern2 = $@"{key1}(.*?){key2}";
            input = Console.ReadLine();
            StringBuilder sb = new StringBuilder();

            foreach (Match match in Regex.Matches(input, pattern2))
            {
                sb.Append(match.Groups[1].Value);
            }

            if (sb.Length > 0)
            {
                Console.WriteLine(sb);
            }
            else
            {
                Console.WriteLine("Empty result");
            }
        }
    }
}

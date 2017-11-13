using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ReplaceATag
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = "<a href=\"(.+?)\">(.+?)<\\/a>";
            string input = Console.ReadLine();

            while (input != "end")
            {
                Match m = Regex.Match(input, pattern);
                string replacement = $"[URL href=\"{m.Groups[1]}\"]{m.Groups[2]}[/URL]";
                Console.WriteLine(Regex.Replace(input, pattern, replacement));
                input = Console.ReadLine();
            }
        }
    }
}

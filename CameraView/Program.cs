using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CameraView
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(?<=\|\<)\w+";
            int[] word = Console.ReadLine().Split(' ')
                .Select(int.Parse).ToArray();
            int m = word[0];
            int n = word[1];
            string input = Console.ReadLine();
            int i = 0;
            int count = Regex.Matches(input, pattern).Count;

            foreach (Match match in Regex.Matches(input, pattern))
            {
                i++;
                if (i < count)
                {
                    Console.Write(new string(match.Value.Skip(m).Take(n).ToArray()) + ", ");
                }
                else
                {
                    Console.WriteLine(new string(match.Value.Skip(m).Take(n).ToArray()));
                }
            }
        }
    }
}

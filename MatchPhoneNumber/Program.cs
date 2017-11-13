using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MatchPhoneNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\+359([ -])2\1[0-9]{3}\1[0-9]{4}\b";
            string input = Console.ReadLine();
            int i = 0;
            int count = Regex.Matches(input, pattern).Count;


            foreach (Match m in Regex.Matches(input, pattern))
            {
                i++;
                if (i < count)
                {
                    Console.Write(m.Value + ", ");
                }
                else
                {
                    Console.WriteLine(m.Value);
                }
            }
        }
    }
}

using System;
using System.Text.RegularExpressions;

namespace Extract_Integer_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine();

            var pattern = @"[0-9]+";

            Regex regex = new Regex(pattern);

            var matches = regex.Matches(text);

            foreach (var match in matches)
            {
                Console.WriteLine(match);
            }
        }
    }
}

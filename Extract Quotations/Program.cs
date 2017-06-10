using System;
using System.Text.RegularExpressions;

namespace Extract_Quotations
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            Regex regex =  new Regex("('|\")(.+?)\\1");

            var matches = regex.Matches(input);

            foreach (Match match in matches)
            {
                Console.WriteLine(match.Groups[2].Value);
            }
        }
    }
}

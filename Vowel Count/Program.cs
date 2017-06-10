using System;
using System.Text.RegularExpressions;

namespace Vowel_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine();

            var pattern = @"[aeiouyAEIOUY]";

            Regex regex = new Regex(pattern);
            var count = regex.Matches(text).Count;

            Console.WriteLine($"Vowels: {count}");
        }
    }
}

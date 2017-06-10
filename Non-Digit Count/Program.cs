using System;
using System.Text.RegularExpressions;

namespace Non_Digit_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine();

            var pattern = @"[^0-9]";

            Regex regex =new Regex(pattern);

            var count = regex.Matches(text).Count;

            Console.WriteLine($"Non-digits: {count}");
        }
    }
}

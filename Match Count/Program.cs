using System;
using System.Text.RegularExpressions;

namespace Match_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            var pattern = Console.ReadLine();
            var text = Console.ReadLine();

            Regex regex = new Regex(pattern);

            var count = regex.Matches(text).Count;

            Console.WriteLine(count);

        }
    }
}

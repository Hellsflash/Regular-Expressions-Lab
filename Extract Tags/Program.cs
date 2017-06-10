using System;
using System.Text.RegularExpressions;

namespace Extract_Tags
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();


            while (input != "END")
            {

                Regex regex = new Regex(@"<.+?>");

                var matches = regex.Matches(input);

                foreach (var match in matches)
                {
                    Console.WriteLine(match);
                }
                
                input = Console.ReadLine();
            }
        }
    }
}

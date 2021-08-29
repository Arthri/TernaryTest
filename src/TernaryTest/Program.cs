using System;

namespace TernaryTest
{
    class Program
    {
        static void Main(string[] args)
        {
            string response = "something so compiler doesn't optimize away";
            Console.WriteLine("Some other thing | " + response);
            var input = Console.ReadLine();
            response = input == "Y"
                ? "Success!"
                : input == "N"
                    ? "Failed"
                    : "Invalid response";
            Console.WriteLine(response);
        }
    }
}

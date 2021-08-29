using System;

namespace TernaryTest
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var input = Console.ReadLine();
            string response;
            if (input == "Y")
            {
                response = "Success!";
            }
            else if (input == "N")
            {
                response = "Failed";
            }
            else
            {
                response = "Invalid response";
            }
            Console.WriteLine(response);
        }
    }
}

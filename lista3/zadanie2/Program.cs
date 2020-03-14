using System;
using System.Text.RegularExpressions;

namespace zadanie2
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {

                #region ipv4
                Console.WriteLine("Enter IP address");
                var input = Console.ReadLine();
                if (input.Length == 0) break;
                var ipAddress = new Regex("^((25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?).){3}(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)$");
                if (ipAddress.IsMatch(input))
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Parsed succesfully");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Parsing Failed");
                }
                Console.ForegroundColor = ConsoleColor.White;

                #endregion

                #region email
                Console.WriteLine("Enter email address");
                input = Console.ReadLine();
                if (input.Length == 0) break;
                var emailAddress = new Regex("^([a-z0-9]+@[a-z0-9]+.{1}[a-z0-9]{2,})$");
                if (emailAddress.IsMatch(input))
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Parsed succesfully");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Parsing Failed");
                }
                Console.ForegroundColor = ConsoleColor.White;

                #endregion


            }
        }
    }
}

using System;

namespace Exercise4
{
    class Ex4Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your Login and Password!");
            var login = Console.ReadLine();
            var password = Console.ReadLine();
            Console.WriteLine("\nNow repeat your Login and Password.\nIf it's will be correct we will play a little game.");
            var logRepeat = Console.ReadLine();
            var pasRepeat = Console.ReadLine();
            logPassCheck(login, password, logRepeat, pasRepeat);
            Console.ReadKey();

        }

        private static void logPassCheck(string login, string password, string logRepeat, string pasRepeat)
        {
            if (logRepeat == login && pasRepeat == password)
            {
                Console.WriteLine("\nLogin and Password are correct.\nNow let's play the game.\nTry to guess the ridlle and write answer.");
                game();
            }
            else Console.WriteLine("\nSorry your Login and Password didn't match.");
        }

        private static void game()
        {
            Console.WriteLine("\nThe same color at winter and summer. Enter your answer (p**e or sp**ce)");
            var answer = Console.ReadLine();
            if (answer == "pine" || answer == "spruce") Console.WriteLine("\nYey! Your win!");
            else Console.WriteLine("\nWell, you tried.");
        }
    }
}

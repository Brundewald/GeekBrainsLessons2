using System;

namespace Exercise4
{
    class Ex4Program
    {
        static void Main(string[] args)
        {
            bool logCheck = false;
            short i = 0;
            Console.WriteLine("Enter your Login and Password!\nIf it's will be correct we will play a little game.");
            string login, password;
            logPasInput(out login, out password);

            while (logCheck == false && i < 3)
            {
                logPasCheck(ref logCheck, ref i, ref login, ref password);
            }

            if (i == 3) Console.WriteLine("Sorry it was your third try.\nGoodbye.");

            game(logCheck);

            Console.ReadKey();

        }

        private static void logPasCheck(ref bool logCheck, ref short i, ref string login, ref string password)
        {
            if (login == "root" && password == "GeekBrains")
            {
                Console.WriteLine("Good, now guess the riddle.");
                logCheck = true;
            }
            else
            {                
                i++;
                Console.WriteLine("Nope, try again.");
                logPasInput(out login, out password);
            }
        }

        private static void logPasInput(out string login, out string password)
        {
            login = Console.ReadLine();
            password = Console.ReadLine();
        }

        private static void game(bool logCheck)
        {
            if (logCheck == true)
            {
                Console.WriteLine("\nThe same color at winter and summer. Enter your answer (p**e or sp**ce)");
                var answer = Console.ReadLine();
                if (answer == "pine" || answer == "spruce") Console.WriteLine("\nYey! Your win!");
                else Console.WriteLine("\nWell, you tried.");
            }
        }

    }

        
}

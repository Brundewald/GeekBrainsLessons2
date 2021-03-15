using System;

/*Created by Nikita Mialkin for GeekBrains*/

namespace Exersize_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi! This programm can chose the lesser number, lets try it!\n");
            Console.WriteLine("Please, enter first number:\n");
            int f_n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please, enter second number:\n");
            int s_n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please, enter third number:\n");
            int t_n = Convert.ToInt32(Console.ReadLine());

            NewMethod(f_n, s_n, t_n);
            
            Console.ReadKey();
        }

        private static int NewMethod(int f_n, int s_n, int t_n)
        {
            if (f_n < s_n && f_n < t_n) Console.WriteLine($"The lesser number is: {f_n}");
            else if (s_n < f_n && s_n < t_n) Console.WriteLine($"The lesser number is: {s_n}");
            else if (t_n < f_n && t_n < s_n) Console.WriteLine($"The lesser number is: {t_n}");
            else Console.WriteLine("There is no lesser number.");
            return 0;
            
        }
    }
}

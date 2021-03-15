using System;

/*Created by Nikita Mialkin for GeekBrains*/

namespace Exercise_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi! This program can count digits in your number. Let's try it!\nPlease enter the number.\n");
            string number = Console.ReadLine();
            int count = NewMethod(number);
            Console.WriteLine($"The amount of digits is: {count}");


        }

        private static int NewMethod(string number)
        {
            int count = 0;
            foreach (char ch in number)
            {
                for (int l = 0; number.Length > l; l++)
                {
                    if (ch == number[l]) count++;
                }
            }

            return count;
        }
    }
}

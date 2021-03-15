using System;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program will allow you to write numbers until you will enter 0.\n");
            int i = Convert.ToInt32(Console.ReadLine());
            int count = 0;
            int oddCount = 0;

            oddCounter(ref i, ref count, ref oddCount);
            Console.WriteLine($"Okay, it's time to stop. You are entered {count} numbers.\nThe count of odd numbers is {oddCount}");

            Console.ReadKey();

        }

        private static void oddCounter(ref int i, ref int count, ref int oddCount)
        {
            while (i > 0)
            {
               
                //Console.WriteLine(i); it for debug
                float odd = i / 2f;
                //Console.WriteLine($"{odd:F2}"); it for debug
                odd = odd - (int)odd;
                if (odd > 0) oddCount++;
                i = Convert.ToInt32(Console.ReadLine());
                count++;

            }
        }
    }
}

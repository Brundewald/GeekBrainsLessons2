using System;

/*Created by Nikita Mialkin for GeekBrains*/

namespace Exercise_7
{
    class Ex7Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi! This program will show you the sequency of numbers and after that their sum.\n");
            Console.Write("Enter number 'a'. It should be lesser than 'b': ");
            var a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter number 'b'. It should be greater than 'a': ");
            var b = Convert.ToInt32(Console.ReadLine());
            Loop(a, b, 0);
                        
        }

       
        static void Loop (int a, int b, int i) 
        {
            Console.Write($" {a}");
            
            if (a < b) 
            {
                Loop(a + 1, b, i = i + a);
              
            }
            else {
                i = i + a;
                Console.Write($" сумма {i}"); 
            }
        }
        
    }
}

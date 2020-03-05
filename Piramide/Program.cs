using System;

namespace Piramide
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give a number to build the piramide:");
            string number = Console.ReadLine();
            int number_int = Convert.ToInt32(number);

            for(int i = number_int - 1, f = 1; i >= 0; i -= 1, f +=2)
            {
                for(int e = i ; e > 0 ; e-= 1)
                {
                    Console.Write(" ");
                }
                for(int u = f; u > 0; u -= 1)
                {
                    Console.Write("*");
                }
                for(int e = i; e > 0; e -= 1)
                {
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
    }
}

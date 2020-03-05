using System;

namespace IncDec
{
    class Program
    {
        static void Main(string[] args)
        {
            int number_1 = 50;
            int number_2;
            number_2 = number_1++;
            Console.WriteLine(number_2);
            number_2 = --number_1;
            Console.WriteLine(number_2);
        }
    }
}

using System;
using System.Collections.Generic;

namespace fizzbuzzagain
{
    class Program
    {
        static void Main(string[] args)
        {
            

            //print fizz if number is divisible by 3
            //print buzz if number is divisible by 5
            //print fizzbuzz if number is divisible by 3 and 5


            List<int> list = new List<int>();

            for (int i = 1; i <= 100; i++)
            {
                list.Add(i);

            }

            foreach (int number in list)
            {
                if (number % 3 == 0 && number % 5 == 0)
                {
                    Console.WriteLine($"Fizzbuzz");
                }
                else if (number % 3 == 0)
                {
                    Console.WriteLine($"Fizz");
                }
                else if (number % 5 == 0)
                {
                    Console.WriteLine($"Buzz");
                }
                else
                {
                    Console.WriteLine($"{number}");
                }

            }




            Console.ReadLine();
        }
    }
}

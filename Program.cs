
// Exercise 4
// Input a value (n) from the user and calculate the sum of first n natural numbers.
// Eg. n=5. sum = 1+2+3+4+5 = 15

using System;

namespace Sum_of_n_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please provide your input number");
            string N = Console.ReadLine();
            int n = Convert.ToInt32(N);

            int sum = 0;

            for (int i =1; i<=n; i++)

            {
                 sum = sum + i;
            }

            Console.WriteLine("Sum of first n natural numbers is"+sum);

        }
    }
}

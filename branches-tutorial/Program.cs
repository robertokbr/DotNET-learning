using System;

namespace BranchesAndLoops
{
    // conditional test
    class Program
    {
        static void ExploreIf()
        {
            int a = 5;
            int b = 3;
            if (a + b > 10)
            {
                Console.WriteLine("The answer is greater than 10");
            }
            else
            {
                Console.WriteLine("The answer is not greater than 10");
            }

            int c = 4;
            if ((a + b + c > 10) && (a > b))
            {
                Console.WriteLine("The answer is greater than 10");
                Console.WriteLine("And the first number is greater than the second");
            }
            else
            {
                Console.WriteLine("The answer is not greater than 10");
                Console.WriteLine("Or the first number is not greater than the second");
            }

            if ((a + b + c > 10) || (a > b))
            {
                Console.WriteLine("The answer is greater than 10");
                Console.WriteLine("Or the first number is greater than the second");
            }
            else
            {
                Console.WriteLine("The answer is not greater than 10");
                Console.WriteLine("And the first number is not greater than the second");
            }
        }

        //chalenge branches + loop:
        // find the sum of all integers 1-20 that are divisible by 3

       
        static void chalenge()
        {
            int sum = 0;
            Console.WriteLine("divisible by 3:");
            for (int numbers=1; numbers<21;numbers++)
            {
                if (numbers % 3 == 0)
                {
                    Console.WriteLine(numbers);
                    sum = sum + numbers;
                }


            }
            Console.WriteLine($"The sum is: {sum}");
        }


        static void Main(string[] args)
        {
            //ExploreIf();
            chalenge();
        }
    }
}
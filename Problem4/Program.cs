using System;

namespace Problem4
{
    class Program
    {
        static void Main()
        {
            int sum1 = 0;
            int sum2 = 0;
            int sum3;
            int diff;
           
            for (int i = 1; i <= 10; i++)
            {
                sum1 += i*i;
                sum2 += i;
            }

            sum3 = sum2*sum2;

            diff = sum3 - sum1;

            

            Console.WriteLine("The difference between sqaures of natural numbers and sum of squares natural number between 1 and 100: "+diff);

            Console.ReadKey();
        }
    }
}

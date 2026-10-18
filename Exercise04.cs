using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project
{
    class Exercise04
    {
        public static void Run()
        {
            Console.WriteLine("Please enter a number:");
            int N = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            int count = 0;
            for (int i = 1; i <= N; i++)
            {
                if (i % 2 == 0)
                {
                    sum += i;
                    count++;

                }
            }
            Console.WriteLine("Count even numbers:" + count);
            Console.WriteLine("The Sum of even numbers:" + sum);
            Console.ReadKey();
        }
    }
}

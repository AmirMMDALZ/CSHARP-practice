using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project
{
    class Exercise01
    {
        public static void Run()
        {
            Console.WriteLine("Please enter a number:");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num % 2 == 0)
                Console.WriteLine("It is Even");
            else
                Console.WriteLine("It is Odd");
        }
    }
    class Exercise02
    {
        public static void Run()
        {
            Console.WriteLine("Please Enter a Number :");
            int N = Convert.ToInt32(Console.ReadLine());
            int Sum = 0;
            for (int i = 1; i <= N; i++)
            {
                Sum += i;
            }
            Console.WriteLine("The Sum Of numbers from 1 to Your Number:" + Sum);
        }
    }
    class Exercise03
    {
        public static void Run()
        {
            for (int i = 1; i <= 20; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
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
            Console.WriteLine("Count even numbers:"+count);
            Console.WriteLine("The Sum of even numbers:"+sum);
        }
    }
}

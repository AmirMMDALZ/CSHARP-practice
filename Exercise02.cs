using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project
{
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
}

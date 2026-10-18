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
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project
{
    class Exercise05
    {
        public static void Run()
        {
            List<float> numbers = new List<float>();

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Enter a number:");
                numbers.Add(Convert.ToSingle(Console.ReadLine()));
            }
            float max = numbers[0];
            float min = numbers[0];
            float sum = 0;
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] > max)
                    max = numbers[i];
                if (numbers[i] < min)
                    min = numbers[i];
                sum += numbers[i];
            }
            float average = sum / numbers.Count;
            Console.WriteLine("Average: " + average);
            Console.WriteLine("Max: " + max);
            Console.WriteLine("Min: " + min);
            Console.WriteLine("Count: " + numbers.Count);
            Console.ReadKey();
        }
    }
}

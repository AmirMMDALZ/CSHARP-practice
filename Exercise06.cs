using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project
{
    class Exercise06
    {
        public static void Run()
        {
            List<float> numbers = new List<float>();
            Console.WriteLine("Please Enter how many numbers you wanna try :");
            int C = Convert.ToInt16(Console.ReadLine());
            if (C <= 0)
            {
                Console.WriteLine("The Number should be above Zero");
                return;
            }
            for (int i = 0; i < C; i++)
            {
                Console.WriteLine("Enter a number:");
                numbers.Add(Convert.ToSingle(Console.ReadLine()));
            }
            float max = numbers[0];
            float min = numbers[0];
            float sum = 0;
            int aboveAverage = 0;
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] > max)
                    max = numbers[i];
                if (numbers[i] < min)
                    min = numbers[i];
                sum += numbers[i];
            }
            float average = sum / numbers.Count;
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] > average)
                {
                    aboveAverage++;
                }
            }
            Console.WriteLine("Above average: " + aboveAverage);
            Console.WriteLine("Average: " + average);
            Console.WriteLine("Max: " + max);
            Console.WriteLine("Min: " + min);
            Console.WriteLine("Count: " + numbers.Count);
            Console.ReadKey();
        }
    }
}


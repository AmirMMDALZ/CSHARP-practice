using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project
{
    class Exercise06
    {
         static float CalculateAverage(List<float> numbers)
         {
            if (numbers.Count==0)
            {
                throw new ArgumentException("the List is empty");
            }
            float Sum = 0;
            foreach (float n in numbers)
            {
                Sum += n;
            }
            float Average = Sum / numbers.Count;
            return Average;
         }
        static float FindMax(List<float> numbers)
        {
            if (numbers.Count == 0)
            {
                throw new ArgumentException("the List is empty");
            }
            float max = numbers[0];
            for (int i = 1; i < numbers.Count; i++)
            {
                if (numbers[i] > max)
                    max = numbers[i];
            }
            return max;
        }
        static float FindMin(List<float> numbers)
        {
            if (numbers.Count == 0)
            {
                throw new ArgumentException("the List is empty");
            }
            float min = numbers[0];
            for (int i = 1; i < numbers.Count; i++)
            {
                if (numbers[i] < min)
                    min = numbers[i];
            }
            return min;
        }
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
            int aboveAverage = 0;
            float average = CalculateAverage(numbers);
            float max = FindMax(numbers);
            float min = FindMin(numbers);
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


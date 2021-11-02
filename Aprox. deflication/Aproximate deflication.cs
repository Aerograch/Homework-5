using System;
using System.Collections.Generic;

namespace Aprox._deflication
{
    class Program
    {
        static int Sum(int[] input)
        {
            int sum = 0;
            foreach(int i in input)
            {
                sum = sum + i;
            }
            return sum;
        }
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            int i;
            i = int.Parse(Console.ReadLine());
            do
            {
                list.Add(i);
                i = int.Parse(Console.ReadLine());
            }
            while (i != 0);
            int[] array = list.ToArray();
            double s = Convert.ToDouble(Sum(array))/Convert.ToDouble(array.Length);
            double sum = 0;
            foreach (int j in array)
            {
                sum += (double)Math.Pow(Convert.ToDouble(j) - s, 2);
            }
            Console.WriteLine((double)Math.Sqrt(sum / (Convert.ToDouble(array.Length) - 1.0)));
        }
    }
}

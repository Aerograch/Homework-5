using System;

namespace Sorting
{
    class Program
    {
        static void Main(string[] args)
        {
            int len = int.Parse(Console.ReadLine());
            int[] input = Array.ConvertAll<string, int>(Console.ReadLine().Split(), new Converter<string, int>(Convert.ToInt32)); //Я решил покопаться в документации и поэксперементировать со встроенными функциями сортировки
            int a;
            for (int i = 1; i < len; i++)
            {
                for (int j = 0; j < len-i; j++)
                {
                    if(input[j] > input[j + 1])
                    {
                        a = input[j];
                        input[j] = input[j + 1];
                        input[j + 1] = a;
                    }
                }
            }
            foreach(int i in input)
            {
                Console.Write($"{i} ");
            }
        }
    }
}

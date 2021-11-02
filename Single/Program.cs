using System;
namespace Single
{
    class Program
    {
        static void Main(string[] args)
        {
            int len = int.Parse(Console.ReadLine());
            string[] input = Console.ReadLine().Split(' ');
            foreach(string s in input)
            {
                if(Array.IndexOf(input, s) == Array.LastIndexOf(input, s))
                {
                    Console.Write($"{s} ");
                }
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}

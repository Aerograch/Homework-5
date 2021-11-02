using System;

namespace Power_of_M
{
    class Program
    {
        static void Main(string[] args)
        {
            int m = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            int power = m;
            while (true)
            {
                if (m == 1)
                {
                    Console.WriteLine("NO");
                    break;
                }
                if (m == 0)
                {
                    Console.WriteLine("YES");
                    break;
                }
                if (power == n)
                {
                    Console.WriteLine("YES");
                    break;
                }
                if (power*m < 0)
                {
                    Console.WriteLine("NO");
                    break;
                }
                power = power * m;
            }
        }
    }
}

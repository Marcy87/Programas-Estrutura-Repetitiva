using System;

namespace Program1153
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            int prod = 1;

            for (int i = 1; i < N; i++)
            {
                prod *= (N - i);
            }

            int total = N * prod;

            Console.WriteLine(total);
        }
    }
}
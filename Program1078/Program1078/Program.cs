using System;

namespace Program1078
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int produto;

            for (int i = 1; i <= 10; i++)
            {
                produto = i * n;
                Console.WriteLine(i + " x " + n + " = " + produto);
            }
        }
    }
}
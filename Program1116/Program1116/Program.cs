using System;
using System.Globalization;

namespace Program1116
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            for (int i = 1; i <= N; i++)
            {
                string[] vet = Console.ReadLine().Split(' ');

                int x = int.Parse(vet[0], CultureInfo.InvariantCulture);
                int y = int.Parse(vet[1], CultureInfo.InvariantCulture);
              
                if (y == 0)
                {
                    Console.WriteLine("divisao impossivel");
                } else
                {
                    double divisao;

                    divisao = (double) x / y;

                    Console.WriteLine(divisao.ToString("F1", CultureInfo.InvariantCulture));
                }
            }
        }
    }
}
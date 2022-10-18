using System;

namespace Program1143
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            for (int i = 1; i <= N; i++)
            {
                Console.Write(i + " ");

                for (int j = 0; j < 1; j++)
                {
                    int mul = i * i;
                    Console.Write(mul + " ");

                    for (int z = 0; z < 1; z++)
                    {
                        int prod = i * mul;
                        Console.Write(prod);
                    }
                }
                Console.WriteLine();
            }

            // OU
            /*int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {

                int primeiro = i;
                int segundo = i * i;
                int terceiro = i * i * i;
                Console.WriteLine($"{primeiro} {segundo} {terceiro}");
            }*/
        }
    }
}
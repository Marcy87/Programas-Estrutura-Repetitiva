using System;

namespace Program1072
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, contIn = 0, contOut = 0;
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++) 
            { 
                x = int.Parse(Console.ReadLine());

                if (x >= 10 && x <= 20)
                {
                    contIn++;
                }
                else
                {
                    contOut++;
                }
            }

            Console.WriteLine(contIn + " in");
            Console.WriteLine(contOut + " out");
        }
    }
}
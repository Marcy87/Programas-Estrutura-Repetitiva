using System;
using System.Globalization;

namespace Program1079
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                string[] vet = Console.ReadLine().Split(' ');
                double x = double.Parse(vet[0], CultureInfo.InvariantCulture);
                double y = double.Parse(vet[1], CultureInfo.InvariantCulture);
                double z = double.Parse(vet[2], CultureInfo.InvariantCulture);

                double media = ((x * 2.0) + (y * 3.0) + (z * 5.0)) / 10.0;
                Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));
            }
        }
    }
}
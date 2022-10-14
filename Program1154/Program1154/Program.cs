using System;
using System.Globalization;

namespace Program1154
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            int soma = 0;
            int cont = 0;
            double media;

            while (idade > 0)
            {
                soma += idade;
                cont++;
                idade = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            media = (double) soma / cont;

            Console.WriteLine(media.ToString("F2"), CultureInfo.InvariantCulture);
        }
    }
}
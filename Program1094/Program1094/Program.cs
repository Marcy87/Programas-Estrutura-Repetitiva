using System;
using System.Globalization;

namespace Program1094
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int ratos = 0;
            int sapos = 0;
            int coelhos = 0;
            int cobaias = 0;

            for (int i = 1; i <= n; i++)
            {
                string[] vet = Console.ReadLine().Split(' ');

                int quantia = int.Parse(vet[0]);
                char tipo = char.Parse(vet[1]);

                if (tipo == 'C')
                {
                    coelhos += quantia;
                } else if (tipo == 'R')
                {
                    ratos += quantia;
                } else
                {
                    sapos += quantia;
                }

                cobaias += quantia;
            }

            double porcentagemCoelhos = (double) coelhos / cobaias * 100.0;
            double porcentagemRatos = (double) ratos / cobaias * 100.0;
            double porcentagemSapos = (double) sapos / cobaias * 100.0;

            Console.WriteLine("Total: " + cobaias + " cobaias");
            Console.WriteLine("Total de coelhos: " + coelhos);
            Console.WriteLine("Total de ratos: " + ratos);
            Console.WriteLine("Total de sapos: " + sapos);
            Console.WriteLine("Percentual de coelhos: " + porcentagemCoelhos.ToString("F2", CultureInfo.InvariantCulture) + " %");
            Console.WriteLine("Percentual de ratos: " + porcentagemRatos.ToString("F2", CultureInfo.InvariantCulture) + " %");
            Console.WriteLine("Percentual de sapos: " + porcentagemSapos.ToString("F2", CultureInfo.InvariantCulture) + " %");
        }
    }
}
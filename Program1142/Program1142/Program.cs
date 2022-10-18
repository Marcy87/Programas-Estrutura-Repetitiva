using System;

namespace Program1142
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            int cont = 0;

            for (int i = 0; i < N; i++)
            { 
                for (int j = 0; j < 3; j++)
                {
                    cont += 1;
                    Console.Write(cont + " ");
                }
                Console.WriteLine("PUM");
                cont += 1;
            }

            // ou

            /* int n = int.Parse(Console.ReadLine());

            int inicio = 1;

            for (int i = 1; i <= n; i++) {

                int segundo = inicio + 1;
                int terceiro = inicio + 2;
                Console.WriteLine(inicio + " " + segundo + " " + terceiro + " PUM");

                inicio = inicio + 4;
            }*/
        }
    }
}
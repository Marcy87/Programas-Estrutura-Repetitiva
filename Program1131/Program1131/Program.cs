using System;

namespace Program1131
{
    class Program
    {
        static void Main(string[] args)
        {
            int cod = 1;
            int contInter = 0;
            int contGremio = 0;
            int grenais = 0;
            int empates = 0;

            while (cod == 1)
            {
                string[] gols = Console.ReadLine().Split(' ');
                                
                int golsInter = int.Parse(gols[0]);
                int golsGremio = int.Parse(gols[1]);
                
                if (golsInter > golsGremio)
                {
                    contInter++;
                }
                else if (golsInter < golsGremio)
                {
                    contGremio++;
                }
                else
                {
                    empates++;
                }

                grenais++;

                Console.WriteLine("Novo grenal (1-sim 2-nao)");
                cod = int.Parse(Console.ReadLine());
            }

            Console.WriteLine(grenais + " grenais");
            Console.WriteLine("Inter:" + contInter);
            Console.WriteLine("Gremio:" + contGremio);
            Console.WriteLine("Empates:" + empates);

            if (contInter > contGremio)
            {
                Console.WriteLine("Inter venceu mais");
            }
            else if (contInter < contGremio)
            {
                Console.WriteLine("Gremio venceu mais");
            }
            else
            {
                Console.WriteLine("Nao houve vencedor");
            }
        }
    }
}
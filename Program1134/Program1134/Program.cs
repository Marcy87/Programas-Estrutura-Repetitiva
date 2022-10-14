using System;

namespace Program1134
{
    class Program
    {
        static void Main(string[] args)
        {
            int contAlcool = 0;
            int contGasolina = 0;
            int contDiesel = 0;

            int tipoComb = 0;

            while (tipoComb != 4)
            {
                if (tipoComb == 1)
                {
                    contAlcool++;
                }
                else if (tipoComb == 2)
                {
                    contGasolina++;
                }
                else if (tipoComb == 3)
                {
                    contDiesel++;
                }
                tipoComb = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("MUITO OBRIGADO");
            Console.WriteLine("Alcool: " + contAlcool);
            Console.WriteLine("Gasolina: " + contGasolina);
            Console.WriteLine("Diesel: " + contDiesel);
        }
    }
}
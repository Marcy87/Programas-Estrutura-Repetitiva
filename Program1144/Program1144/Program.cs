﻿using System;

namespace Program1144
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            for (int i = 1; i <= N; i++)
            {
                int segundo = i * i;
                int terceiro = i * i * i;
                Console.WriteLine(i + " " + segundo + " " + terceiro);
                Console.WriteLine(i + " " + (segundo + 1) + " " + (terceiro + 1));
            }
        }
    }
}
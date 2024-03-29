﻿using System;

namespace Pascaltriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] arr = new int[8, 8];

            // Initialize the first row
            arr[0, 0] = 1;

            Console.WriteLine("Pascal triangle:");

            for (int i = 1; i < 8; i++)
            {
                for (int k = 7; k > i; k--)
                {
                    Console.Write(" ");
                }

                for (int j = 0; j <= i; j++)
                {
                    if (j == 0 || j == i)
                    {
                        arr[i, j] = 1;
                    }
                    else
                    {
                        arr[i, j] = arr[i - 1, j] + arr[i - 1, j - 1];
                    }

                    Console.Write(" " + arr[i, j]);
                }

                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}

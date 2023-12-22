// // Задача 2: Задайте двумерный массив. Напишите программу, которая
// // поменяет местами первую и последнюю строку массива.

using System;

class Program
{
    static void Main(string[] args)
    {
        int[,] array = new int[4, 4];

        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array[i, j] = new Random().Next(-10, 10);
            }
        }
        Console.WriteLine("The random array:");
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write("{0,3}", array[i, j]);
            }
            Console.WriteLine();
        }
        Console.WriteLine("Array after replasing strings:");
        SwapRows(array);

    }
    
    static void SwapRows(int[,] array)
    {
        for(int i = 0; i < array.GetLength(1); i++)
            {
                var tmp = array[3, i];
                array[3, i] = array[0, i];
                array[0, i] = tmp;
            }
            for(int i = 0; i < array.GetLength(0); i++)
            {
                for(int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write("{0,3}", array[i, j]);
                }
                Console.WriteLine();
            }
    }
}
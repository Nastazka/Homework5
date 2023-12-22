// Задача 3: Задайте прямоугольный двумерный массив. Напишите
// программу, которая будет находить строку с наименьшей суммой элементов.

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
                array[i, j] = new Random().Next(1, 10);
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

        int minSum = int.MaxValue;
        int minSumRow = 0;

        for (int i = 0; i < array.GetLength(0); i++)
        {
            int sum = 0;
            for (int j = 0; j < array.GetLength(1); j++)
            {
                sum += array[i, j];
                if (sum < minSum)
                {
                    minSum = sum;
                    minSumRow = i+1;
                }
            }
            
        }

        Console.WriteLine("The row with the smallest sum of elements: {0}", minSumRow);
    }
}
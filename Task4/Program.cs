// Задача 4*(не обязательная): Задайте двумерный массив из целых чисел.
// Напишите программу, которая удалит строку и столбец, на пересечении
// которых расположен наименьший элемент массива. Под удалением понимается
// создание нового двумерного массива без строки и столбца

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

        int minValue = int.MaxValue;
        int minValueRow = 0;
        int minValueColumn = 0;

        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (array[i, j] < minValue)
                {
                    minValue = array[i, j];
                    minValueRow = i;
                    minValueColumn = j;
                }
            }
        }

        int[,] newArray = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];

        int row = 0;
        int column = 0;

        for (int i = 0; i < array.GetLength(0); i++)
        {
            if (i != minValueRow)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (j != minValueColumn)
                    {
                        newArray[row, column] = array[i, j];
                        column++;
                    }
                }
                row++;
                column = 0;
            }
        }

        Console.WriteLine("New array:");
        for (int i = 0; i < newArray.GetLength(0); i++)
        {
            for (int j = 0; j < newArray.GetLength(1); j++)
            {
                Console.Write("{0,3}", newArray[i, j]);
            }
            Console.WriteLine();
        }
    }
}
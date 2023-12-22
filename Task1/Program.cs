// Задача 1: Напишите программу, которая на вход принимает позиции элемента в двумерном
// массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
using System;

public class Program
{
    public static void Main(string[] args)
    {
        int[,] array = new int[5, 5];

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

        Console.WriteLine("Enter the line number (0, 1, 2, 3, 4):");
        int x = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the column number (0, 1, 2, 3, 4):");
        int y = int.Parse(Console.ReadLine());

        int value = FindElement(array, x, y);

        if (value == -1)
        {
            Console.WriteLine("There is no such element:(");
        }
        else
        {
            Console.WriteLine("Value of the element: {0}", value);
        }
    }

    public static int FindElement(int[,] array, int x, int y)
    {
        if (x < 0 || x >= array.GetLength(0) || y < 0 || y >= array.GetLength(1))
        {
            return -1;
        }

        return array[x, y];
    }
}
﻿// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int[,] FillMatrix(int rows, int columns)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random ();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = rnd.Next(1,10);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i,j] + "\t");
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Введите количество строк и столбцов через пробел: ");
string[] input = Console.ReadLine().Split();
int row = int.Parse(input[0]);
int col = int.Parse(input[1]);
int[,] array = FillMatrix(row,col);
PrintMatrix(array);
Console.WriteLine();

int[] sums = new int[row];
for (int i = 0; i < array.GetLength(0); i++)
{
    int sum = 0;
    for (int j = 0; j < array.GetLength(1) - 1; j++)
    {
        sum = sum + array[i,j];
    }
    sums[i] = sum;
}

int min = sums[0];
int minInd = 0;
for (int i = 1; i < sums.Length; i++)
{
    if(sums[i] < min)
    {
        min = sums[i];
        minInd = i;
    }
}

Console.WriteLine("Номер строки с наименьшей суммой элементов: " + (minInd + 1));
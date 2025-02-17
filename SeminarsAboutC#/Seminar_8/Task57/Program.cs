﻿// Задача 57: Составить частотный словарь элементов двумерного массива. Частотный словарь содержит информацию о том,
// сколько раз встречается элемент входных данных.

// 1 2 3
// 4 6 1
// 2 1 6

// 1 встречается 3 раза
// 2 встречается 2 раз
// 3 встречается 1 раз
// 4 встречается 1 раз
// 6 встречается 2 раза

int[,] myArray = {
    { 1, 2, 3 },
    { 4, 6, 1 },
    { 2, 1, 6 }
};

int[] counter = new int[10];

for(int i = 0; i < myArray.GetLength(0); i ++)
{
    for(int j = 0; j < myArray.GetLength(1); j ++)
    {
        counter[myArray[i,j]]++;
    }
}

for(int i = 0; i < counter.Length; i++)
{
    if(counter[i] != 0) Console.WriteLine(i + " встречается " + counter[i] + " раз");
}
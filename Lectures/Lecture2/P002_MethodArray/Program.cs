﻿int[] array = {11,12,31,4, 18,15,16,17,18};

int n = array.Length; //возвращает кол-во элементов массива

int find = 18;

int index = 0;

while (index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++; // index = index + 1;
}

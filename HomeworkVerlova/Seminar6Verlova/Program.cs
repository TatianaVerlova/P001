﻿// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

// Console.Write("Какое количество чисел вы хотите ввести? ");
// int size = int.Parse(Console.ReadLine());
// int[] input = FillArrayByUser(size);
// Console.Write("Количество чисел больше 0 составляет " + CountOfPositiveNumbers(input));


// int[] FillArrayByUser(int length)
// {
//     int[] array = new int[length];
//     for(int i = 0; i < length; i++)
//     {
//         Console.Write("Введите число: ");
//         array[i] = int.Parse(Console.ReadLine());
//     }
//     return array;
// }

// int CountOfPositiveNumbers(int[] array)
// {
//     int count = 0;
//     for(int i = 0; i < array.Length; i++)
//     {
//         if(array[i] > 0)
//         {
//             count++;
//         }
//     }
//     return count;
// }



// ******************************************************************************************************************************

// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; 5,5)

Console.Write("Введите значение b1: ");
double b1 = double.Parse(Console.ReadLine());

Console.Write("Введите значение k1: ");
double k1 = double.Parse(Console.ReadLine());

Console.Write("Введите значение b2: ");
double b2 = double.Parse(Console.ReadLine());

Console.Write("Введите значение k2: ");
double k2 = double.Parse(Console.ReadLine());

if(k1 != k2)
{
    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * x + b1;
    Console.Write("Точка пересечения двух прямых (" + x + "; " + y + ")");
}
else
{
    Console.Write("Прямые параллельны");
}
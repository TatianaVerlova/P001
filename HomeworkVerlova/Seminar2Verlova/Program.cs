﻿// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
//
// 456 -> 5
// 782 -> 8
// 918 -> 1

// Console.WriteLine("Enter a number: ");
// int num = int.Parse(Console.ReadLine());

// void getSecondDigit(int number)
// {
//     int firstTwoDigits = number / 10;
//     int secondDigit = firstTwoDigits % 10;
//     Console.WriteLine(secondDigit);
// }

// getSecondDigit(num);



// *********************************************************************************************************************************

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

// Console.WriteLine("Enter a number: ");
// string numString = Console.ReadLine();
// int num = int.Parse(numString);

// if (num >= 100)
// {
//     Console.WriteLine(numString[2]);
// }
// else
// {
//     Console.WriteLine("третьей цифры нет");
// }



// *********************************************************************************************************************************

// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день 
//выходным.
//
// 6 -> да
// 7 -> да
// 1 -> нет

// Console.Write("Введите номер дня недели ");
// int number = int.Parse(Console.ReadLine());

// if (number == 6 || number == 7)
// {
//     Console.Write("да");
// }
// else
// {
//     Console.Write("нет");
// }



// *********************************************************************************************************************************

// Дополнительное задание: Напишите программу, которая принимает на вход число N и выводит все простые числа в промежутке от 0 до N 
// (включительно). После, попробуйте поэксперментировать с величиной значения N и понаблюдать за тем, как оно влияет на время 
//выполнения программы.

// Console.Write("Введите число: ");
// int num = int.Parse(Console.ReadLine());

// int i = 2;

// while (i <= num)
// {
//     int j = 2;
//     int k = 0;
//     while (j*j <= i && k != 1)
//     {
//         if (i % j == 0)
//         {
//             k = 1;
//         }
//         j++;
//     }
//     if (k != 1)
//     {
//         Console.Write(i + " ");
//     }
//     i++;
// }
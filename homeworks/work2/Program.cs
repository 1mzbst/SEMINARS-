﻿//ЗАДАЧА 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

//РЕШЕНИЕ:

// Console.WriteLine("Please, enter the three-digit number."); // three-digit number - Tdn

// int Tdn = Convert.ToInt32(Console.ReadLine());

// int SecNum = (Tdn / 10) % 10; // SecNum - second number;

// Console.WriteLine($"The Second number of {Tdn} is {SecNum}.");
// ______________________________________________________________________________________________________________________________________

//ЗАДАЧА 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

//РЕШЕНИЕ:

// Console.WriteLine("Hey there, engage the any number! ");
// int AnyNum = Convert.ToInt32(Console.ReadLine());
// int AnyNumBU = AnyNum; // The backup of AnyNum. For Console. 
// int ThirdNum = 0;


// int FindThirdNum(int AnyNum, int ThirdNum)
// {
//     if (AnyNum < 100)
//     {
//         Console.WriteLine("The third number is absent today.");
//         return AnyNum;
//     }

//     while (AnyNum > 1000)
//     {
//         AnyNum /= 10;
//     }
//     Console.WriteLine($"The third number of {AnyNumBU} is {ThirdNum = AnyNum % 10}.");

//     return ThirdNum;

// }
// FindThirdNum(AnyNum, ThirdNum);

// ______________________________________________________________________________________________________________________________________

// ЗАДАЧА 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

//РЕШЕНИЕ 1:

// Console.WriteLine("Enter, a day of the week."); // A day of the week - DoW

// int DoW = Convert.ToInt32(Console.ReadLine());

// if (DoW < 6)
// {
//     Console.WriteLine("The sun still high, come back to work!");
// }
// else
// {
//     Console.WriteLine("It's party time!");
// }

//РЕШЕНИЕ 2:

// Console.WriteLine("Enter, a day of the week."); // A day of the week - DoW

// int DoW = Convert.ToInt32(Console.ReadLine());

// void week(int DoW)
// {
//     if (DoW > 0 && DoW < 6) Console.WriteLine("The sun still high, come back to work!");
//     if (DoW > 5 && DoW < 8) Console.WriteLine("It's party time!");
//     else
//     {
//         Console.WriteLine("What type of calendar do you use?");
//     }
// }

// week(DoW);
// ______________________________________________________________________________________________________________________________________






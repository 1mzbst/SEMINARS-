﻿//Задача 1. Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9].
// Найдите сумму отрицательных и положительных элементов массива.
//Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.

// int[] CreatRandomArray(int size, int minValue, int maxValue)
// {
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(minValue, maxValue + 1);
//     }
//     return array;
// }
// void ShowArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }

// void FindPosNegxSum(int[] array)

// {
//     int sumPositiv = 0;
//     int sumNegativ = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] >= 0) sumPositiv += array[i];
//         else sumNegativ += ShowArray[i];
//     }
//     Console.WriteLine($"Sum of positive numbers in array -> {sumPositiv}, sum of negarive numbers -> {sumNegativ}");
// }

// Console.WriteLine("Input array size");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input minimal value of array element");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input maximal value of array element");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// int[] myArray = CreateRandomArray(size, minValue, maxValue);
// ShowArray(mArray);
// FindPosNegxSum(myArray);

//Задача 2. Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
//[-4, -8, 8, 2] -> [4, 8, -8, -2]

// int[] CreateRandomArray(int size, int minValue, int maxValue)
// {
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(minValue, maxValue + 1);
//     }
//     return array;
// }

// void ShowArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }

// int[] InvertArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] *= (-1);
//     }
//     return array;
// }

// Console.WriteLine("Input array size");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input minimal value of array element");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input max value of array element");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// int[] myArray = CreateRandomArray(size, minValue, maxValue);
// ShowArray(myArray);
// myArray = InvertArray(myArray);
// ShowArray(myArray);


//Задача 3.Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
//4; массив [6, 7, 19, 345, 3] -> нет

// РЕШЕНИЕ:

// int[] CreateRandomArray(int size, int minValue, int maxValue)
// {
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(minValue, maxValue + 1);
//     }
//     return array;
// }

// void ShowArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }

// bool FindNum(int[] array, int num)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] == num) return true;

//     }
//     return false;
// }

// Console.WriteLine("Input array size");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input minimal value of array element");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input max value of array element");
// int maxValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Inpute number");
// int num = Convert.ToInt32(Console.ReadLine());

// int[] myArray = CreateRandomArray(size, minValue, maxValue);
// ShowArray(myArray);
// Console.WriteLine(FindNum(myArray, num));

//__________________________________________________________________________________________________________________


//Задача 4.****Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, 
//значения которых лежат в отрезке [10,99].

// РЕШЕНИЕ:

// int[] CreateRandomArray(int size, int minValue, int maxValue)
// {
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(minValue, maxValue + 1);
//     }
//     return array;
// }

// void ShowArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }

// void Nums(int[] array)
// {
//     int call = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if ((array[i] >= 10) && (array[i] <= 99))
//         {
//             call++;
//         }
//     }
//     Console.WriteLine($"В массиве значений которых лежат в отрезке [10,99] = {call}");
// }

// Console.WriteLine("Input array size");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input minimal value of array element");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input max value of array element");
// int maxValue = Convert.ToInt32(Console.ReadLine());


// int[] nums = CreateRandomArray(size, minValue, maxValue);
// ShowArray(nums);
// Nums(nums);

//__________________________________________________________________________________________________________________

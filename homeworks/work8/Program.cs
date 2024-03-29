﻿// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

// Решение

// int[,] Create2DRandomArray(int columns, int rows, int minValue, int maxValue)
// {
//     int[,] newArray = new int[rows, columns];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             newArray[i, j] = new Random().Next(minValue, maxValue + 1);

//         }
//     }
//     return newArray;

// }

// void Show2DArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// //ПРОВЕРКА СОРТИРОВКИ СТРОКИ:
// // void ShowArray(int[] array)       
// // {
// //     for (int i = 0; i < array.Length; i++)
// //     {
// //         Console.Write(array[i] + " ");
// //     }
// //     Console.WriteLine();
// // }


// int[] BubleSort(int[] array)
// {
//     int temp = 0;
//     for (int k = 0; k < array.Length; k++)
//     {
//         for (int l = 0; l < array.Length - 1; l++)
//         {

//             if (array[l] < array[l + 1]) // sort in descending order "<"
//             {
//                 temp = array[l + 1];
//                 array[l + 1] = array[l];
//                 array[l] = temp;
//             }
//         }
//     }
//     return array;
// }

// int[,] FindCue(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         // int j = 0;
//         int[] jArray = new int[array.GetLength(1)];

//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             jArray[j] = array[i, j];

//         }

//         BubleSort(jArray);

//         for (int j = 0; j < jArray.Length; j++)
//         {
//             array[i, j] = jArray[j];
//         }

//     }
//     Console.WriteLine();
//     return array;
// }



// Console.WriteLine("Input number of rows: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input number of colums: ");
// int columns = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input minimal value of array element");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input max value of array element");
// int maxValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine();

// int[,] MyArray = Create2DRandomArray(columns, rows, minValue, maxValue);
// Show2DArray(MyArray);
// Console.WriteLine();
// Show2DArray(FindCue(MyArray));



// ______________________________________________________________________________________________________________________________

// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

// Решение

// int[,] Create2DRandomArray(int columns, int rows, int minValue, int maxValue)
// {
//     int[,] newArray = new int[rows, columns];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             newArray[i, j] = new Random().Next(minValue, maxValue + 1);

//         }
//     }
//     return newArray;

// }

// void Show2DArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// // ПРОВЕРКА СОРТИРОВКИ СТРОКИ:
// // void ShowArray(int[] array)
// // {
// //     for (int i = 0; i < array.Length; i++)
// //     {
// //         Console.Write(array[i] + " ");
// //     }
// //     Console.WriteLine();
// // }


// int MinValueSort(int[] array)
// {
//     int index = 0;
//     int temp = array[0];
//     for (int k = 0; k < array.Length; k++)
//     {
//         if (array[k] < temp)
//         {
//             index = k;
//             temp = array[k];

//         }

//     }
//     return index;
// }

// int FindMinRaw(int[,] array)
// {
//     int[] minRawArray = new int[array.GetLength(0)];
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         int temp = 0;
//         int[] jArray = new int[array.GetLength(1)];

//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             jArray[j] = array[i, j];
//             temp = temp + jArray[j];

//         }
//         minRawArray[i] = temp;

//     }
//     // ShowArray(minRawArray); / показывает сумму
//     return MinValueSort(minRawArray);
// }



// Console.WriteLine("Input number of rows: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input number of colums: ");
// int columns = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input minimal value of array element");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input max value of array element");
// int maxValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine();

// int[,] MyArray = Create2DRandomArray(columns, rows, minValue, maxValue);
// Show2DArray(MyArray);
// Console.WriteLine();
// Console.WriteLine($"The minimal sum in the {FindMinRaw(MyArray) + 1} row.");


// _________________________________________________________________________________________________________________________

// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

//Решение

// int[,] Create2DRandomArray(int columns, int rows, int minValue, int maxValue)
// {
//     int[,] newArray = new int[rows, columns];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             newArray[i, j] = new Random().Next(minValue, maxValue + 1);

//         }
//     }
//     return newArray;

// }

// int[,] Create2DRandomArray2(int columns2, int rows2, int minValue2, int maxValue2)
// {
//     int[,] newArray = new int[rows2, columns2];
//     for (int i = 0; i < rows2; i++)
//     {
//         for (int j = 0; j < columns2; j++)
//         {
//             newArray[i, j] = new Random().Next(minValue2, maxValue2 + 1);

//         }
//     }
//     return newArray;

// }




// int[,] MultiplyArray(int[,] array, int[,] array2)
// {
//     int[,] array3 = new int[array.GetLength(0), array2.GetLength(1)];
//     for (int i = 0; i < array.GetLength(0); i++)
//     {


//         for (int j = 0; j < array2.GetLength(1); j++)
//         {
//             int multy = 0;
//             int sum = 0;
//             for (int k = 0; k < array.GetLongLength(1); k++)
//             {
//                 multy = array[i, k] * array2[k, j];
//                 sum = sum + multy;
//             }
//             array3[i, j] = sum;
//         }
//     }
//     return array3;
// }


// void Show2DArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }


// Console.WriteLine("Input number of rows: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input number of colums: ");
// int columns = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input minimal value of array element");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input max value of array element");
// int maxValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine();

// Console.WriteLine("Input number of rows2: ");
// int rows2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input number of colums2: ");
// int columns2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input minimal2 value of array element");
// int minValue2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input max value of array element");
// int maxValue2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine();


// int[,] MyArray = Create2DRandomArray(columns, rows, minValue, maxValue);
// int[,] MyArray2 = Create2DRandomArray2(columns2, rows2, minValue2, maxValue2);
// Show2DArray(MyArray);
// Show2DArray(MyArray2);
// Show2DArray(MultiplyArray(MyArray, MyArray2));



// _________________________________________________________________________________________________________________________

// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

//Решение

// int[,,] Create3DRandomArray(int columnsX, int columnZ, int rows, int minValue, int maxValue)
// {
//     int[,,] newArray = new int[rows, columnsX, columnZ];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columnsX; j++)
//         {
//             for (int k = 0; k < columnZ; k++)
//             {
//                 newArray[i, j, k] = new Random().Next(minValue, maxValue + 1);

//             }
//         }
//     }
//     return newArray;

// }

// void Show3DArray(int[,,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             for (int k = 0; k < array.GetLength(2); k++)
//             {
//                 Console.Write($"{array[i, j, k]} {(i, j, k)} ");
//             }
//             Console.WriteLine();
//         }
//         // Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// Console.WriteLine("Input number of rows: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input number of columsX: ");
// int columnsX = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input number of columsZ: ");
// int columnsZ = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input minimal value of array element");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input max value of array element");
// int maxValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine();

// int[,,] MyArray = Create3DRandomArray(columnsX, columnsZ, rows, minValue, maxValue);
// Show3DArray(MyArray);


//Решение

// int[,,] Create3DRandomArray(int columnsX, int columnZ, int rows, int minValue, int maxValue)
// {
//     int[,,] newArray = new int[rows, columnsX, columnZ];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columnsX; j++)
//         {
//             for (int k = 0; k < columnZ; k++)
//             {
//                 newArray[i, j, k] = new Random().Next(minValue, maxValue + 1);

//             }
//         }
//     }
//     return newArray;

// }

// void Show3DArray(int[,,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             for (int k = 0; k < array.GetLength(2); k++)
//             {
//                 Console.Write($"{array[i, j, k]} {(i, j, k)} ");
//             }
//             Console.WriteLine();
//         }
//         // Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// Console.WriteLine("Input number of rows: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input number of columsX: ");
// int columnsX = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input number of columsZ: ");
// int columnsZ = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input minimal value of array element");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input max value of array element");
// int maxValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine();

// int[,,] MyArray = Create3DRandomArray(columnsX, columnsZ, rows, minValue, maxValue);
// Show3DArray(MyArray);
// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:

// _________________________________________________________________________________________________________________________


// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

//Решение

// int[,] NumbersArray(int row, int column)
// {
//     int temp = 0;
//     int n = 1;
//     int[,] array = new int[row, column];
//     for (int i = 0; i < 1; i++)
//     {
//         for (int j = 0; j < column; j++)
//         {
//             array[i, j] = n++;
//             temp = j;
//         }

//         for (int q = 1; q < 4; q++)
//         {
//             array[q, column - 1] = n++;
//             // array[column - 1, q] = n++;
//         }

//         for (int w = -2; w < 1; w++)
//         {
//             array[row - 1, w * (-1)] = n++;
//         }

//         for (int e = -2; e < 0; e++)
//         {
//             array[e * (-1), i] = n++;
//         }

//         for (int r = 1; r < 3; r++)
//         {
//             array[i + 1, r] = n++;
//         }

//         for (int t = -2; t < 0; t++)
//         {
//             array[i + 2, t * (-1)] = n++;
//         }
//     }

//     return array;
// }
// void Show2DArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// int[,] MyArray = NumbersArray(3, 3);
// Show2DArray(MyArray);





// _________________________________________________________________________________________________________________________
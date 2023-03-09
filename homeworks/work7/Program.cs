// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2

// 1 -3,3 8 -9,9

// 8 7,8 -7,1 9

//Решение.

// double[,] Create2DRandomArray(int columns, int rows, double minValue, double maxValue)
// {
//     double[,] newArray = new double[rows, columns];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             newArray[i, j] = Math.Round(-minValue + new Random().NextDouble() * (maxValue + minValue), 4);
//             //new Random().Next(minValue, maxValue + 1);

//         }
//     }
//     return newArray;

// }

// void Show2DArray(double[,] array)
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
// double minValue = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Input max value of array element");
// double maxValue = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine();
// double[,] array = Create2DRandomArray(columns, rows, maxValue, maxValue);
// Show2DArray(array);

// Show2DArray(Create2DRandomArray(columns, rows, minValue, maxValue));


// ______________________________________________________________________________________________________________________________

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 17 -> такого числа в массиве нет

//Решение.

int[,] Create2DRandomArray(int columns, int rows, int minValue, int maxValue)
{
    int[,] newArray = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            newArray[i, j] = new Random().Next(minValue, maxValue + 1);

        }
    }
    return newArray;

}

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

int[,] CheckNum(int entNum, int[,] array)
{
    int rowNum = 0;
    int columNum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] == entNum) Console.WriteLine(array[i, j]);
            else Console.WriteLine("There is no number in array.");
        }
    }
    return array;
}


// Console.WriteLine("Input number of rows: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input number of colums: ");
// int columns = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input minimal value of array element");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input max value of array element");
// int maxValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input number of : ");
// int entNum = Convert.ToInt32(Console.ReadLine());

// CheckNum(entNum, Create2DRandomArray);

// int[,] array = Create2DRandomArray(columns, rows, maxValue, maxValue);

// Show2DArray(array);
// Show2DArray(Create2DRandomArray(columns, rows, minValue, maxValue));

// ______________________________________________________________________________________________________________________________

// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

//Решение.

// ______________________________________________________________________________________________________________________________

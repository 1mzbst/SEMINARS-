//Задача 1. Задайте двумерный массив размером m×n, заполненный случайными целыми числами.

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

// int[,] array = Create2DRandomArray(columns, rows, maxValue, maxValue);

// Show2DArray(array);
// Show2DArray(Create2DRandomArray(columns, rows, minValue, maxValue));

// _____________________________________________________________________________________________________________________________


//Задача 2. ****Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₘₙ = m+n.
// Выведите полученный массив на экран.

//Решение

// int[,] Create2DRandomArray(int columns, int rows)
// {
//     int[,] newArray = new int[rows, columns];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             newArray[i, j] = i + j;
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
// Console.WriteLine("Input number of rows: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input number of colums: ");
// int columns = Convert.ToInt32(Console.ReadLine());

// Show2DArray(Create2DRandomArray(columns, rows));

// _____________________________________________________________________________________________________________________________

//Задача 3.Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.

//Например, изначально массив выглядел вот так:

//1 4 7 2
//5 9 2 3
//8 4 2 4
//Новый массив будет выглядеть вот так:
//1 4 7 2
//5 **81  ** 2 **9**
//8 4 2 4

//Решение

// int[,] Create2DArray(int columns, int rows)
// {
//     int[,] newArray = new int[rows, columns];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             newArray[i, j] = i + j;
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

// int[,] FindNum(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if (i % 2 == 0 && j % 2 == 0)
//             {
//                 array[i, j] *= array[i, j];
//                 // array[i] *= array[i];
//                 // array[j] *= array[j];
//             }

//         }

//     }
//     return array;

// }

// Console.WriteLine("Input number of rows: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input number of colums: ");
// int columns = Convert.ToInt32(Console.ReadLine());

// int[,] MyArray = Create2DArray(columns, rows);
// Show2DArray(MyArray);
// Console.WriteLine();
// FindNum(MyArray);
// Console.WriteLine();
// Show2DArray(MyArray);

// _____________________________________________________________________________________________________________________________


//Задача 4. адайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.

//Решение

int[,] Create2DArray(int columns, int rows)
{
    int[,] newArray = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            newArray[i, j] = i + j;
        }
    }
    return newArray;
}

void Show2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int FindMainDiagonal(int[,] array)
{
    int sum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {

        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i == j) sum = array[i, j] + sum;
        }

    }
    return sum;

}

Console.WriteLine("Input number of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number of colums: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] MyArray = Create2DArray(columns, rows);
Show2DArray(MyArray);
Console.WriteLine();
// FindMainDiagonal(MyArray); так нельзя
Console.WriteLine(FindMainDiagonal(MyArray));

// _____________________________________________________________________________________________________________________________
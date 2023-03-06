// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу,
// которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

// Решение

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

// int FindEvenNumber(int[] array)
// {
//     int count = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] % 2 == 0) count += 1;
//     }
//     Console.WriteLine(count);
//     return count;
// }

// Console.WriteLine("Input array size");
// int size = Convert.ToInt32(Console.ReadLine());
// // ShowArray(CreatRandomArray(size, 100, 999));
// int[] MyArray = CreatRandomArray(size, 100, 999);
// ShowArray(MyArray);
// FindEvenNumber(MyArray);

// _________________________________________________________________________________________________

// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

// Решение

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

// void FindSum(int[] array)
// {
//     // int count = 0;
//     int sum = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (i % 2 != 0) sum += array[i];
//     }
//     Console.WriteLine(sum);
// }

// Console.WriteLine("Input array size");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input minimal value of array element");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input maximal value of array element");
// int maxValue = Convert.ToInt32(Console.ReadLine());


// int[] MyArray = CreatRandomArray(size, minValue, maxValue);
// ShowArray(MyArray);
// FindSum(MyArray);

// _________________________________________________________________________________________________

// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

// Решение.

double[] CreatRandomArray(int size, double minValue, double maxValue)
{
    double[] array = new double[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = Math.Round(minValue + new Random().NextDouble() * (maxValue + minValue), 4);

    }
    return array;
}
void ShowArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

void FindMinMax(double[] array)
{
    double minNum = array[0];
    double maxNum = array[0];
    // double firstIndex = array[0];

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] >= maxNum) maxNum = array[i];
        if (minNum >= array[i]) minNum = array[i];
    }
    Console.WriteLine();
    Console.WriteLine($"The minimal digit of the array is {minNum} and the max digit is {maxNum}.");
    // Console.WriteLine();
    // Console.WriteLine(minNum);


}

Console.WriteLine("Input array size");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input minimal value of array element");
double minValue = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input maximal value of array element");
double maxValue = Convert.ToDouble(Console.ReadLine());



double[] MyArray = CreatRandomArray(size, minValue, maxValue);
ShowArray(MyArray);
FindMinMax(MyArray);


// _________________________________________________________________________________________________

// int arrayFindEN = FindEvenNumber(CreatRandomArray(size, 100, 999));
// ShowArray()
// ShowArray(CreatRandomArray(size, 100, 999));

// Console.WriteLine("Input minimal value of array element");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input maximal value of array element");
// int maxValue = Convert.ToInt32(Console.ReadLine());


// _________________________________________________________________________________________________________________________

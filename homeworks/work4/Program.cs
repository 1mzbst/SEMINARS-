// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.


// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

// РЕШЕНИЕ:

Console.WriteLine("Enter the number.");
int num = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter the power.");
int pow = Convert.ToDouble(Console.ReadLine());
int count = 0;
double NumInPow(double num, double pow, int count)
{
    while (count != pow)
    {
        numPow = num * num;
        count++;
    }

    // return result;
}

NumDeg(num, deg);

// ___________________________________________________________________________________________________________________

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

// РЕШЕНИЕ:

// Console.WriteLine("Enter the number.");
// int num = Convert.ToInt32(Console.ReadLine());
// int numBU = num; // numBU for num in console.
// int result = 0;
// int numRem = 0;

// int SumOfDigit(int num, int result, int numRem)
// {
//     while (num != 0)
//     {
//         numRem = num % 10;
//         result = numRem + result;
//         num = num / 10;
//     }
//     Console.WriteLine($"The count of digit in {numBU} is {result}.");
//     return result;
// }

// SumOfDigit(num, result, numRem);

// ___________________________________________________________________________________________________________________

// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]

// РЕШЕНИЕ:

// int[] CreateRandomArray(int size)
// {
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(0, size);
//     }
//     return array;
// }
// void ShowArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
// }
// ShowArray(CreateRandomArray(8));

// ___________________________________________________________________________________________________________________
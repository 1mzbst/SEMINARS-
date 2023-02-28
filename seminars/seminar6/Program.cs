//Задача 1. Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, 
//а первый - на последнем и т.д.)

//[1 2 3 4 5] -> [5 4 3 2 1]
//[6 7 3 6] -> [6 3 7 6]

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

// int[] ReservArray(int[] array)
// {
//     for (int i = 0; i < array.Length / 2; i++)
//     {
//         int temp = array[i];
//         array[i] = array[array.Length - i - 1];
//         array[array.Length - i - 1] = temp;
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
// int[] reverseArray = ReservArray(myArray);
// ShowArray(reverseArray);

//_________________________________________________________________


//Задача 2.Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.
//самое важное знать правило, какждая сторона должна быть меньше(строго) суммы двух других сторон

// Решение

// bool CheckTriangle(int x, int y, int z)
// {
//     if ((x < y + z) && (y < z + x) && (z < x + y))
//     {
//         return true;
//     }
//     return false;
// }

// Console.WriteLine("Input length of a");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input length of b");
// int b = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input length of c");
// int c = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine($"Does the Triangle with sides {a} and {b} and {c} exist? {CheckTriangle(a, b, c)}");

// ________________________________________________________________________________________________________________________________________

//Задача 3. Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: a и b.

//числа фибоначчи последовательность чисел в которой первые 2 числа это 0 и 1, а последубщие это сумма двух передыдущих
//[0, 1,2, 3, 5, 8, 13, ... ]

//Решение

// void ShowArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }

// int[] FebDigit(int a, int firstNum, int secNum)
// {
//     int[] array = new int[a];
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (i == 0)
//         {
//             array[i] = firstNum;
//         }
//         else if (i == 1)
//         {
//             array[i] = secNum;
//         }
//         else
//         {
//             array[i] = array[i - 1] + array[i - 2];
//         }

//     }
//     return array;
// }

// Console.WriteLine("Input n");
// int a = Convert.ToInt32(Console.ReadLine());

// ShowArray(FebDigit(a, 8, 9));

// _______________________________________________________________________________________________________________________

//Задача 4. ****Напишите программу, которая будет преобразовывать десятичное число в двоичное.

//45 -> 101101
//3 -> 11
//2 -> 10

// Решение

// string DecNum(int num)
// {
//     string result = string.Empty;
//     while (num != 0)
//     {
//         result = num % 2 + result;
//         num = num / 2;

//     }
//     return result;
// }
// Console.WriteLine("Input number");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(DecNum(a));

// _______________________________________________________________________________________________________________________
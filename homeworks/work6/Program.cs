// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3

//Решение.

int[] CreatArray(int size) //int minValue, int maxValue)
{
    int sumOfIndex = 0;
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        Console.WriteLine($"Write the not more {size} positive and negative numbers."); // Поместить над for
        array[i] = Convert.ToInt32(Console.ReadLine());
        if (array[i] > 0) sumOfIndex += 1;
    }
    Console.WriteLine(sumOfIndex);
    return array;
}

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

// int FindEvenNumber(int[] array)
// {
//     int count = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] % 2 == 0) count += 1;
//     }
//     Console.WriteLine($" The count of even numbers is {count}.");
//     return count;
// }

Console.WriteLine("Input array size");
int size = Convert.ToInt32(Console.ReadLine());
int[] MyArray = CreatArray(size);
ShowArray(CreatArray(size));
// FindEvenNumber(MyArray);

//___________________________________________________________________________________________________________________

// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

//Решение.

//___________________________________________________________________________________________________________________

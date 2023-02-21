// int FindSum(int a)
// {
//     int sum = 0;
//     for (int current = 1; current <= a; current++)
//     {
//         sum = sum + current;// sum+=current;
//     }
//     return sum;

// }

// Console.WriteLine("Input A ");
// int a = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine(FindSum(a));

//___________________________________________________________________________________________________________

//Задача 4. Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.

// [1,0,1,1,0,1,0,0]

// РЕШЕНИЕ:

int[] CreatRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1);
    }
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
Console.WriteLine("Input array size");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input minimal value of array element");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input maximal value of array element");
int maxValue = Convert.ToInt32(Console.ReadLine());

//int[] myArray = CreatRandomArray(size, minValue, maxValue);

ShowArray(CreatRandomArray(size, minValue, maxValue));
// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу,
// которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

// Решение



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

int FindEvenNumber(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0) count += 1;
    }
    Console.WriteLine(count);
    return count;
}

Console.WriteLine("Input array size");
int size = Convert.ToInt32(Console.ReadLine());
// ShowArray(CreatRandomArray(size, 100, 999));
int[] MyArray = CreatRandomArray(size, 9, 100);
ShowArray(MyArray);
FindEvenNumber(MyArray);



// int arrayFindEN = FindEvenNumber(CreatRandomArray(size, 100, 999));
// ShowArray()
// ShowArray(CreatRandomArray(size, 100, 999));

// Console.WriteLine("Input minimal value of array element");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input maximal value of array element");
// int maxValue = Convert.ToInt32(Console.ReadLine());









// _________________________________________________________________________________________________________________________

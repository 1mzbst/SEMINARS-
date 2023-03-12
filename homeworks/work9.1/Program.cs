int[] RandomArray(int minValue, int maxValue, int size)
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

int[] BubleSort(int[] array)
{
    int temp = 0;
    for (int j = 0; j < array.Length; j++)
    {
        for (int i = 0; i < array.Length - 1; i++)
        {

            if (array[i] < array[i + 1])
            {
                temp = array[i + 1];
                array[i + 1] = array[i];
                array[i] = temp;
            }
        }
    }
    return array;
}

Console.WriteLine("Input array size");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input minValue");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input maxValue");
int maxValue = Convert.ToInt32(Console.ReadLine());

int[] RunArray = RandomArray(minValue, maxValue, size);
ShowArray(RunArray);
ShowArray(BubleSort(RunArray));

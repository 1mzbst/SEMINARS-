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
    for (int i = 0; i < array.Length; i++)
    {
        for (int j = 0; j < array.Length - 1; j++)
        {

            if (array[j] < array[j + 1]) // sort in descending order "<"
            {
                temp = array[j + 1];
                array[j + 1] = array[j];
                array[j] = temp;
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

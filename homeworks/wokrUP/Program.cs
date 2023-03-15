//ЗАПИСЬ В МАССИВ ГЛАВНОЙ ДИАГОНАЛИ

int[,] FindCue(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        // int temp = 0;
        int[] jArray = new int[0];
        for (int j = 0; j < array.GetLength(1); j++)
        {
            // temp = array[i, j];
            jArray = new int[array.GetLength(1)];
            jArray[j] = array[i, j];
            Console.Write(jArray[i] + " ");

        }
        Console.WriteLine();
        // ShowArray(BubleSort(jArray));
    }
    return array;
}


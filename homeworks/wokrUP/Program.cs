// //ЗАПИСЬ В МАССИВ ГЛАВНОЙ ДИАГОНАЛИ

// int[,] FindCue(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         // int temp = 0;
//         int[] jArray = new int[0];
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             // temp = array[i, j];
//             jArray = new int[array.GetLength(1)];
//             jArray[j] = array[i, j];
//             Console.Write(jArray[i] + " ");

//         }
//         Console.WriteLine();
//         // ShowArray(BubleSort(jArray));
//     }
//     return array;
// }


// // ПЕРЕВОРОТ МАССИВА!!!
// int[,] RevolveArray(int[,] array)
// {
//     // int[,] revAr = new int[6, 4];
//     int agl1 = array.GetLength(1);
//     int agl0 = array.GetLength(0);
//     int[,] revArray = new int[agl1, agl0];
//     for (int i = -array.GetLength(1) + 1; i < 1; i++)

//     {

//         for (int j = 0; j < agl0; j++)
//         {
//             revArray[j, i * (-1)] = array[i + (agl1 - 1), j];


//             // Console.Write(revArray[j, i] + " ");
//         }

//     }
//     int[,] revrevArray = new int[revArray.GetLength(0), revArray.GetLength(1)];
//     for (int q = 0; q < revArray.GetLength(1))//(int q = -revArray.GetLength(1) + 1; q < 1; q ++)
//     {
//         for (int w = 0; w < revArray.GetLength(0); w++)
//         {
//             revrevArray[q, w] = revArray[]
//         }
//     }
//     // revArray = revAr;
//     return revArray;

// Console.WriteLine("Enter the size ");
// int size = Convert.ToInt32(Console.ReadLine());
// string[] nstring = new string[size];
string[] nstring = { "zero", "one", "two", "three", "four" };

void ShowArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine(array[i] + " ");
    }
}
ShowArray(nstring);

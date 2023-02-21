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
// Console.WriteLine("Input array size");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input minimal value of array element");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input maximal value of array element");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// //int[] myArray = CreatRandomArray(size, minValue, maxValue);

// ShowArray(CreatRandomArray(size, minValue, maxValue));

// _______________________________________________________________________________________________________________________
//Задача 2.Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.

//456 -> 3
//78 -> 2
//89126 -> 5

// РЕШЕНИЕ:

// int CountNumber(int num)

// {
//     int count = 0;
//     while (count < num)
//     {
//         num /= 10;
//         count++;
//     }
//     return count;
// }

// Console.WriteLine(CountNumber(75987));

// __________________________________________________________________________________________________________
//Задача 3. Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.

//4  -> 24
//5  -> 120


// РЕШЕНИЕ:

// int Factor(int Num)
// {
//     int n = 1;
//     for (int i = 1; i <= Num; i++)
//     {
//         n = n * i;

//     }
//     return n;
// }
// Console.WriteLine("Input number");
// int Num = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(Factor(Num));

//______________________________________________________________________________________________________________________________
// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3

//Решение.

// int[] CreatArray(int size)
// {
//     int sumOfIndex = 0;
//     int[] array = new int[size];
//     Console.WriteLine($"Write the not more then {size} positive and negative numbers.");
//     for (int i = 0; i < size; i++)
//     {

//         array[i] = Convert.ToInt32(Console.ReadLine());
//         if (array[i] > 0) sumOfIndex += 1;

//     }
//     Console.WriteLine($"The sum of positive index is {sumOfIndex}.");
//     return array;
// }

// Console.WriteLine("Input array size");
// int size = Convert.ToInt32(Console.ReadLine());
// int[] MyArray = CreatArray(size);

//___________________________________________________________________________________________________________________

// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


// k1 * x + b1 = k2 * x + b2
// k1 * x - k2 * x = b2 - b1
// x = (b2-b1)/(k1-k2)

//Решение.

// double FindCrossPoint(double angCoefk1, double angCoefk2, double coefb1, double coefb2)
// {
//     double x = (coefb2 - coefb1) / (angCoefk1 - angCoefk2);
//     double y = angCoefk1 * x + coefb1;
//     Console.WriteLine($"The intersection point is ({x},{y}).");
//     return y;
// }

// Console.WriteLine("Enter a coefficient 'b1'. ");
// double coefb1 = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Enter an angular coefficient 'k1'. ");
// double angCoefk1 = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Enter a coefficient 'b2'. ");
// double coefb2 = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Enter an angular coefficient 'k2'. ");
// double angCoefk2 = Convert.ToDouble(Console.ReadLine());


// FindCrossPoint(angCoefk1, angCoefk2, coefb1, coefb2);



//___________________________________________________________________________________________________________________

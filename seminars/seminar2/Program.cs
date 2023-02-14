//Задача1

// int MaxDecimal(int num)
// {
//     int ed = num % 10;
//     int dec = num / 10;
//     if (ed > dec)
//     {
//         Console.WriteLine($"Большая цифра числа {num} -> {ed}");

//         return ed;


//     }
//     else
//     {
//         Console.WriteLine($"Большая цифра числа {num} -> {dec}");

//         return dec;
//     }
// }

// int RandomNumber = new Random().Next(10, 99 + 1);

// MaxDecimal(RandomNumber);

//Задача 2

// Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.

// 456 -> 46

// 782 -> 72

// 918 -> 98

// int DeleteDecimal(int num)
// {
//     int sot = num / 100;
//     int ed = num % 10;
//     return sot * 10 + ed;

// }

// int RandomNumber = new Random().Next(100, 1000);

// Console.WriteLine(RandomNumber);

// int result = DeleteDecimal(RandomNumber);

// Console.WriteLine(DeleteDecimal(RandomNumber));

// Задача3

// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.

// 14  ->  нет
// 46  ->  нет
// 161 ->  да

// Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если второе число не кратно числу первому, то программа выводит остаток от деления.

// 34, 5 -> не кратно, остаток 4
// 16, 4  -> кратно

//Задача 4

// int Devid723(int num)
// {
//     if (num % 7 == 0 && num % 23 == 0)
//     {
//         Console.WriteLine("Ок");
//     }
//     else
//     {
//         Console.WriteLine("Нет");
//     }
// }
// Console.WriteLine("input number");
// int Number = Convert.ToInt32(Console.ReadLine());

// Devid723(Number);

// Задача 5

// void KratDecimal(double num1, double num2)
// {
//     if (num1 % num2 == 0)
//     {
//         Console.WriteLine("Кратно");
//     }
//     else
//     {
//         Console.WriteLine($"Остаток от деления {num1} / {num2} = {num1 % num2}");
//     }
// }

// Console.WriteLine("Imput first number");
// double num1 = Convert.ToDouble(Console.ReadLine());

// Console.WriteLine("Imput second number");
// double num2 = Convert.ToDouble(Console.ReadLine());

// KratDecimal(num1, num2);
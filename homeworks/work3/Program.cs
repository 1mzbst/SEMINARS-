// ЗАДАЧА 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да


// РЕШЕНИЕ:

// Console.WriteLine("Enter the number"); // polydrome - Poly
// int Number = Convert.ToInt32(Console.ReadLine());
// int FRem = 0;
// int SRem = 0;
// int FNum = 0;
// int SNum = 0;
// 
// int PolyFunc(int FRem, int SRem, int FNum, int SNum)
// {
//     FRem = Number % 10;
//     SRem = (Number / 10) % 10;
//     FNum = Number / 10000;
//     SNum = (Number / 1000) % 10;
//     if (FRem == FNum && SRem == SNum)
//     {
//         Console.WriteLine($"Wow! The {Number} is the POLYDROME!");
//     }
//     else
//     {
//         Console.WriteLine("Boooooriiiiing....");
//     }

//     return 0;
// }

// PolyFunc(FRem, SRem, FNum, SNum);

// ______________________________________________________________________________________________________________________________

// ЗАДАЧА 21

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

// РЕШЕНИЕ:

// int Length(int x1, int x2, int y1, int y2, int z1, int z2)
// {
//     return Math.Round(Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2)), 2);
// }
// Console.WriteLine("Enter the coordinate x1 of point A");
// int x1 = Convert.Toint(Console.ReadLine());
// Console.WriteLine("Enter the coordinate y1 of point A");
// int y1 = Convert.Toint(Console.ReadLine());
// Console.WriteLine("Enter the coordinate z1 of point A");
// int z1 = Convert.Toint(Console.ReadLine());
// Console.WriteLine("Enter the coordinate x2 of point B");
// int x2 = Convert.Toint(Console.ReadLine());
// Console.WriteLine("Enter the coordinate y2 of point B");
// int y2 = Convert.Toint(Console.ReadLine());
// Console.WriteLine("Enter the coordinate z2 of point B");
// int z2 = Convert.Toint(Console.ReadLine());

// Console.WriteLine($"The distance beetwean points A and B is {Length(x1, x2, y1, y2, z1, z2)} ");

// ______________________________________________________________________________________________________________________________

// ЗАДАЧА 23

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

// РЕШЕНИЕ:

// Console.WriteLine("Enter the finite number N");

// int NumN = Convert.ToInt32(Console.ReadLine()); // NumN - finite number N

// int count = 0;

// void Cube(int count)
// {
//     while (count <= NumN)
//     {
//         Console.WriteLine($"The {count} in cube is {Math.Pow(count, 3)}.");
//         count++;
//     }
// }
// Cube(count);
// ______________________________________________________________________________________________________________________________






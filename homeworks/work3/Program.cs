// ЗАДАЧА 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да


// РЕШЕНИЕ:

Console.WriteLine("Enter the number"); // polydrome - Poly
int Number = Convert.ToInt32(Console.ReadLine());

int PolyFunc(int Number)
{
    Frem = Number % 10 + Number % 100;
    // Srem = Frem % 100;
    // Number * 0.1;
    return (Console.WriteLine(Frem));
}
PolyFunc(Number);


// ______________________________________________________________________________________________________________________________

// ЗАДАЧА 21

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

// РЕШЕНИЕ:

// double Length(double x1, double x2, double y1, double y2, double z1, double z2)
// {
//     return Math.Round(Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2)), 2);
// }
// Console.WriteLine("Enter the coordinate x1 of point A");
// double x1 = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Enter the coordinate y1 of point A");
// double y1 = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Enter the coordinate z1 of point A");
// double z1 = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Enter the coordinate x2 of point B");
// double x2 = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Enter the coordinate y2 of point B");
// double y2 = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Enter the coordinate z2 of point B");
// double z2 = Convert.ToDouble(Console.ReadLine());

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






// Задача1
//  Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

// int FindQuart(double x, double y)
// {
//     if (x > 0 && y > 0) return 1;
//     if (x < 0 && y > 0) return 2;
//     if (x < 0 && y < 0) return 3;
//     if (x > 0 && y < 0) return 4;

//     return 0;
// }
// Console.WriteLine("Input X: ");
// int x = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input Y: ");
// int y = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine(FindQuart(x, y));

//Задача 3. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

//A (3,6); B (2,1) -> 5,09
//A (7,-5); B (1,-1) -> 7,21

// double FindDistance(double x1, double y1, double x2, double y2)
// {
//     // return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
//     return Math.Round(Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2)), 2);
// }

// Console.WriteLine("Input coordinate X for first point: ");
// double x1 = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Input coordinate Y for first point: ");
// double y1 = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Input coordinate X for second point: ");
// double x2 = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Input coordinate Y for second point: ");
// double y2 = Convert.ToDouble(Console.ReadLine());

// Console.WriteLine($"Distance between our points -> {FindDistance(x1, y1, x2, y2)}");

//Задача 2.Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).


// Console.WriteLine("Четверть");
// int quart = Convert.ToInt32(Console.ReadLine());

// void FindDeapason(int quart)
// {
//     if (quart == 1) Console.WriteLine("x > 0; y > 0");
//     if (quart == 2) Console.WriteLine("x < 0; y > 0");
//     if (quart == 3) Console.WriteLine("x < 0; y < 0");
//     if (quart == 4) Console.WriteLine("x > 0; y < 0");
// }

// FindDeapason(quart);




//Задача 4. Напишите программу которая принимает на вход число (N) и выдает на консоль квадраты чисел от 1 до N
// Console.WriteLine("Число");
// int N = Convert.ToInt32(Console.ReadLine());

// void Quad(int N)
// {
//     int y = 1;
//     while (y <= N)
//     {
//         Console.WriteLine(Math.Pow(y, 2));
//         y++;
//     }

// }

// Quad(N);


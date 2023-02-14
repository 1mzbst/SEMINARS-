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

int DeleteDecimal(int num)
{
    int sot = num / 100;
    int ed = num % 10;
    return sot * 10 + ed;

}

int RandomNumber = new Random().Next(100, 1000);

Console.WriteLine(RandomNumber);

int result = DeleteDecimal(RandomNumber);

Console.WriteLine(DeleteDecimal(RandomNumber));
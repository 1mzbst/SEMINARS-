
// // Задача1
// Console.WriteLine("Введите первое число");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число");
// int num2 = Convert.ToInt32(Console.ReadLine());

// if (num1 > num2)
// {
//     Console.WriteLine($"Первое число ({num1}) больше второго числа ({num2}).");
// }
// else if (num1 == num2)
// {
//     Console.WriteLine($"Первое число ({num1}) равно второму числу ({num2}).");
// }
// else
// {
//     Console.WriteLine($"Второе число ({num2}) больше первого числа ({num1}).");
// }

//Задача2.
// Console.WriteLine("Дай первое число!");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Дай второе число!");
// int num2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Дай третье число!");
// int num3 = Convert.ToInt32(Console.ReadLine());

// if (num1 > num2 && num1 > num3)
// {
//     Console.WriteLine($"Победило первое число! ({num1})");
// }
// else if (num1 == num2 && num1 == num3 && num3 == num2)
// {
//     Console.WriteLine("Ну, что ты начинаешь...");
// }
// else if (num2 > num1 && num2 > num3)
// {
//     Console.WriteLine($"Победа за вторым числом!({num2})");
// }
// else
// {
//     Console.WriteLine($"Победитель - число под номером три!({num3})");
// }

//Задача3

// Console.WriteLine("Число, пожалуйста.");
// int num1 = Convert.ToInt32(Console.ReadLine());
// int modulo = num1 % 2;

// if (modulo == 0)
// {
//     Console.WriteLine("Да, мисье!");
// }
// else
// {
//     Console.WriteLine("Нетс..");
// }

//Задача4

// Console.WriteLine("Введите конечное число.");
// int numN = Convert.ToInt32(Console.ReadLine());
// int multipleNum = 2;

// if (numN <= 1)
// {
//     Console.WriteLine(multipleNum = 0);
// }
// else
// {
//     while (multipleNum <= numN)
//     {
//         Console.Write($"{multipleNum} ");
//         multipleNum = multipleNum + 2;
//     }
// }
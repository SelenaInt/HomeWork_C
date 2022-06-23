// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22
Console.WriteLine("Hello, Amigo");
Console.WriteLine("Введите любое целое число");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе целое число");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье целое число");
int c = Convert.ToInt32(Console.ReadLine());


if (a > b && a > c)
    {
        Console.WriteLine("максимальное из трех чисел: {0} ", a);
    }
    else if (b > a && b > c)
    {
        Console.WriteLine("максимальное из трех чисел: {0} ", b);
    }
    else
    {
        Console.WriteLine("максимальное из трех чисел: {0} ", c);
    }







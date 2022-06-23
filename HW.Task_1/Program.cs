// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт,
//какое число большее, а какое меньшее.

//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3
Console.WriteLine("Hello, Amigo!");
Console.WriteLine("Введите любое целое число");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе целое число");
int b = Convert.ToInt32(Console.ReadLine());

if (a!=b)
{
    if (a > b)
    {
        Console.WriteLine("ваше первое число {0} является наибольшим", a);
        Console.WriteLine("ваше второе число {0} является наименьшим", b);
    }

    else
    {
        Console.WriteLine("ваше второе число {0} является наибольшим", b);
        Console.WriteLine("ваше первое число {0} является наименьшим", a);
    }
}
else
{
    Console.WriteLine("ваши числа равны");
}

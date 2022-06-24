// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.WriteLine("Hello, Amigo!");

Console.Write("Введите любое целое число : ");
int N = Convert.ToInt32(Console.ReadLine());

int i = 1;

Console.WriteLine("Наши четные числа диапазона от 0 до введенного вами  " +N);

while  (i <= N) 
{
    if (i % 2 == 0) // (i % 2 == 0) сортировка четного числа

    {
        Console.WriteLine(i);
    }
    i +=1;
}

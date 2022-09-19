/* Задача 2. Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = -9 b = -3 -> max = -3*/


Console.WriteLine("Введите первое число: ");
int a = int.Parse(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int b = int.Parse(Console.ReadLine());

if (a > b) 
{
    Console.WriteLine($"max = {a}, min = {b}");
}

else if (b > a)
{
     Console.WriteLine($"max = {b}, min = {a}");
}
else 
{
    Console.WriteLine("числа равны");
}

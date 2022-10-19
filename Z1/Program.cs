// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.WriteLine("Программа которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее");
Console.WriteLine("Введите первое число: ");
int number_1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число: ");
int number_2 = int.Parse(Console.ReadLine()!);

if (number_1 > number_2)
{
    Console.WriteLine(number_1 + " больше чем " + number_2);
}
else
{
    Console.WriteLine(number_2 + " больше чем " + number_1);
}
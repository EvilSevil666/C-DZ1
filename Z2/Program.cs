﻿// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.WriteLine("Программа которая принимает на вход три числа и выдаёт максимальное из этих чисел.");
Console.WriteLine("Введите первое число: ");
int number_1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число: ");
int number_2 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите третье число: ");
int number_3 = int.Parse(Console.ReadLine()!);

int max = number_1;
if (number_2 > max) max = number_2;
if (number_3 > max) max = number_3;

Console.WriteLine("Максимальное число " + max);

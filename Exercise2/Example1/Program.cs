// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Console.WriteLine("Введите трехзначное число: ");
int num = int.Parse(Console.ReadLine()!);
int a = num / 10;
int b = a % 10;
Console.WriteLine (b);
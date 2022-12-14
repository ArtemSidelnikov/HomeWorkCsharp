// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine()!);
if (num<100)
{
    Console.WriteLine("Нет третьей цифры");
}
else
{
       while (num >= 1000)
    {
         num = num/10;
    }
int a = num % 10;
Console.WriteLine(a);
}
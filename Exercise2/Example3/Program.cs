//  Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine()!);
if (num>7)
{
    Console.WriteLine("Error");
}
else
{
    if (num>5)
    {
      Console.WriteLine("Выходной");  
    }
    else
    {
        Console.WriteLine("Рабочий");
    }
}
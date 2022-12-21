//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine()!);
int num2=1;
while (num2<=num)
{
   Console.WriteLine(num2*num2*num2);
   num2=num2+1; 
}
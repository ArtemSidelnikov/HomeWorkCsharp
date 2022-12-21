//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве
Console.WriteLine("Введите координаты первой точки x, y, z: ");
float x1 = float.Parse (Console.ReadLine()!);
float y1 = float.Parse (Console.ReadLine()!);
float z1 = float.Parse (Console.ReadLine()!);
Console.WriteLine("Введите координаты второй точки x, y, z: ");
float x2 = float.Parse (Console.ReadLine()!);
float y2 = float.Parse (Console.ReadLine()!);
float z2 = float.Parse (Console.ReadLine()!);
float Sum = (x2-x1)*(x2-x1)+(y2-y1)*(y2-y1)+(z2-z1)*(z2-z1);
Console.Write("Расстояние: ");
Console.WriteLine(MathF.Sqrt(Sum)); 
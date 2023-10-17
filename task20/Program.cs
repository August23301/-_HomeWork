/*
20. Напишите программу, которая принимает на вход координаты двух точек и находит
расстояние между ними в 2D пространстве.
A (3,6); B (2,1) -> 5,09
A (7,-5); B (1,-1) -> 7,21
*/

Console.Write ("Введите координату Х первой точки ");
int firstX = int.Parse(Console.ReadLine());
Console.Write ("Введите координату Y первой точки ");
int firstY = int.Parse(Console.ReadLine());
Console.Write ("Введите координату Х второй точки ");
int secondX = int.Parse(Console.ReadLine());
Console.Write ("Введите координату Y второй точки ");
int secondY = int.Parse(Console.ReadLine());

double distance = Math.Sqrt(Math.Pow(secondX - firstX, 2) + Math.Pow(secondY -firstY, 2));
distance = Math.Round(distance,2);

Console.WriteLine (distance);


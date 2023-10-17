/*
Внутри класса Answer напишите метод DistanceBetweenPoints, который принимает на вход координаты двух т
очек pointA и pointB в виде массива целых чисел, и возвращает расстояние между ними в 3D пространстве.
*/
System.Console.WriteLine("Введите координату Х точки А");
int pointAX = int.Parse(Console.ReadLine());
System.Console.WriteLine("Введите координату Y точки А");
int pointAY = int.Parse(Console.ReadLine());
System.Console.WriteLine("Введите координату Z точки А");
int pointAZ = int.Parse(Console.ReadLine());
System.Console.WriteLine("Введите координату Х точки B");
int pointBX = int.Parse(Console.ReadLine());
System.Console.WriteLine("Введите координату Y точки B");
int pointBY = int.Parse(Console.ReadLine());
System.Console.WriteLine("Введите координату Z точки B");
int pointBZ = int.Parse(Console.ReadLine());

double distance = Math.Sqrt((Math.Pow(pointBX - pointAX, 2)) + Math.Pow(pointBY - pointAY, 2) + Math.Pow(pointBZ - pointAZ, 2));

System.Console.WriteLine(Math.Round(distance, 2));
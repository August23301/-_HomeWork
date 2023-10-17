/*
22. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.

5 -> 1, 4, 9, 16, 25.
2 -> 1,4
*/

Console.Write("Введи число ");
int number = int.Parse(Console.ReadLine());

for (double i = 0; i <= number; i++)
{
    double pow = Math.Pow(i, 2);
    Console.Write($"{pow}");
    if (i < number)
        Console.Write(", ");
}
/*
7. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
456 -> 6
782 -> 2
918 -> 8
*/

System.Console.WriteLine("Введите натуруальное трёхзначное число");
int number = Convert.ToInt32(Console.ReadLine());

int converted_number = number%10;
System.Console.WriteLine($"Последняя цифра числа {number} будет {converted_number}");
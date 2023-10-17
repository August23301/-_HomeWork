/*
Внутри класса Answer напишите метод IsPalindrome, который принимает на вход пятизначное число number и проверяет, является ли оно палиндромом.

Метод должен проверить является ли число пятизначным, в противном случае - вывести Число не пятизначное и False в следующей строке.

Для остальных чисел вернуть True или False.
*/

System.Console.Write("Введите пятизначное число ");
int number = int.Parse(Console.ReadLine());

int first = number / 10000;
int second = number / 1000 % 10;
int fifth = number % 10;
int four = number % 100 / 10;

if (first == fifth && second == four)
{
    System.Console.WriteLine("Thats Palindromeeee!!!");
}
else
{
    System.Console.WriteLine("Thats  NOT Palindromeeee!!!");
}

if (number > 100000 || number < 9999)
    System.Console.WriteLine("Число не пятизначное");
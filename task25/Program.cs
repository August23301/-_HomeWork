/*
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

System.Console.Write("Give me your number "); // ИНИЦИАЛИЗИРУЮ ПЕРЕМЕННЫЕ, КОТОРЫЕ ВВОДИТ ТИПА ЮЗЕР
int userNumber = int.Parse(Console.ReadLine());
System.Console.Write("Give me your stepen' ");
int userStepen = int.Parse(Console.ReadLine());

double userResult = Stepen(userNumber, userStepen); // ВЫЗОВ МЕТОДА
System.Console.WriteLine(userResult); // ИНИЦИАЛИЗАЦИЯ РЕЗУЛЬТАТА МЕТОДА

double Stepen(int number, int stepen)
{
    double result = Math.Pow (number,stepen);
    return result;
}
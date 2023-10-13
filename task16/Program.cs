/*16.Напишите программу, которая принимает на вход два числа и проверяет,
является ли одно число квадратом другого.
5, 25 -> да
-4, 16 -> да
25, 5 -> да
8,9 -> нет*/

System.Console.WriteLine("введи 1 число");
int firstNumber = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("введи 2oe число");
int secondNumber = Convert.ToInt32(Console.ReadLine());

if (firstNumber*firstNumber == secondNumber || secondNumber*secondNumber == firstNumber) 
System.Console.WriteLine("da");
else
{
    System.Console.WriteLine("net");
}
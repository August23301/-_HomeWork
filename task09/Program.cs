/*9. Напишите программу, которая выводит случайное
 число из отрезка [10, 99] и показывает наибольшую цифру числа.
78 -> 8
12-> 2
85 -> 8*/

int number = new Random().Next(10, 100);
System.Console.WriteLine(number);
int firstNumber = number / 10;
int secondNumber = number % 10;

if (firstNumber > secondNumber)
    System.Console.WriteLine($"Наибольшая числа числа {number} является - {firstNumber}");
else
    System.Console.WriteLine($"Наибольшая числа числа {number} является - {secondNumber}");


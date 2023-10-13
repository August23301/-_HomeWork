/*
1. Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
456 -> 46
782 -> 72
918 -> 98
*/

int randomNumber = new Random().Next(100,1000);
int firstNumber =randomNumber/100;
int secondNumber =randomNumber/10%10; // Ненужная переменная кста, я минут 5 думал как эту цифру найти
int thirdNumber = randomNumber%10;

int resultNumber =firstNumber*10+thirdNumber;

System.Console.WriteLine($"Братик, ты загадал число {randomNumber}, которое состоит из цифр {firstNumber}, {secondNumber}, {thirdNumber} соотвественно и после всех манипуляций получится число {resultNumber}");
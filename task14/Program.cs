﻿/*14. Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
14 -> нет
46 -> нет
161 -> да*/

System.Console.WriteLine("Введи число, да эй");
int number = Convert.ToInt32(Console.ReadLine());

if (number%7 ==0 && number%23 ==0){
    System.Console.WriteLine("дэ, кратно и 23, и 7");
}
else 
System.Console.WriteLine("Нэт, нэ кратно");
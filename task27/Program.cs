/*
Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/

int SumOfDigits (int num)
{
    int result =0;
    while (num>0)
    {
        result = num%10 +result; //нахожу последнюю цифру и суммирую
        num = num/10; // делаю шаг, сокращая число на последнюю цифру, чтобы цикл продолжался
    }
    return result;
}

System.Console.Write("Need a number ");
int userNumber = int.Parse(Console.ReadLine());

int userResult = SumOfDigits(userNumber);
System.Console.WriteLine(userResult); 
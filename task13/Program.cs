/*Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6*/

int num = new Random().Next(10, 333333);
System.Console.WriteLine(num);

ThirdTcifra(num);

void ThirdTcifra(int number)
{
    if (number < 100)
    {
        System.Console.WriteLine("Третьей цирфы нет");
    }

while (num>999)
{
    num/=10;
}
System.Console.WriteLine(num%10);
return;
}

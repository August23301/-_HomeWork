/*Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/

System.Console.WriteLine("Введите цирфру, обозначующую д.н.");
int numDay = Convert.ToInt32(Console.ReadLine());
if (numDay > 5 && numDay<8)
{
    System.Console.WriteLine("da");
}
else if  (numDay <= 5 && numDay > 0){
    System.Console.WriteLine("no");
}

else
{
    System.Console.WriteLine("Число должно быть от 1ого до 7ми!");
}
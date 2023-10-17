/*
Внутри класса Answer напишите метод ShowCube, который принимает на вход число (N) 
и выводит таблицу кубов чисел от 1 до N (включительно) каждое на новой строке.
*/

System.Console.Write("Введите число ");
int number = int.Parse(Console.ReadLine());

for (int i = 0; i <= number; i++)
{
double cube = Math.Pow(i, 3);
System.Console.WriteLine(cube);
}
/*
28. Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
4 -> 24
5 -> 120
*/
System.Console.Write("GIVE TO ME N!!! ");
int userNumber = int.Parse(Console.ReadLine());
int userResult = Composition(userNumber);
System.Console.WriteLine(userResult);

int Composition(int number)
{
    int result = 1;
    for (int i = 1; i <= number; i++)
    {
        result*=i;
    }
    return result;
}
/*
26. Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
456 -> 3
78 -> 2
89126 -> 5
*/
System.Console.Write("Дай мне наамбер ");
int userNumber = int.Parse(Console.ReadLine());

int count = CountOfLetters(userNumber);
System.Console.WriteLine(count);

int CountOfLetters(int number)
{
    int result = 0;
    for (int i = number; i > 0; i /= 10)
    {
        result += 1;
    }
    return result;
}
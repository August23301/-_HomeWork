/*
69. Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
*/

int Step(int num, int square)
{
    if (square == 1)
    {
        return num;
    }

    else
    {
        return num*Step(num,square-1);
    }
}

int result =Step(3,2);
System.Console.WriteLine(result);
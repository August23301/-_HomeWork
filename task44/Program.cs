/*
Не используя рекурсию. выведи первые N чисел фибоначи
*/

System.Console.WriteLine("Cкок цифр надо ");         // 0  1  1  2  3  5  8
int num = int.Parse(Console.ReadLine());
Fibonaci(num);

void Fibonaci(int number)
{
    int[] fibonaci = new int[number + 1];
    if (number == 0) System.Console.WriteLine("1");
    else
    {
        for (int i = 0; i < 2; i++)
        {
            fibonaci[i] = i;
            System.Console.Write(fibonaci[i] + " ");
        }

        for (int i = 2; i < number; i++)
        {
            fibonaci[i] = fibonaci[i - 2] + fibonaci[i - 1];
            System.Console.Write(fibonaci[i] + " ");
        }
    }
}
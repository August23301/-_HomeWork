/*
Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/

int FuncAccerman(int n, int m)
{
    if (n == 0)
        return m + 1;
    else
      if ((n != 0) && (m == 0))
        return FuncAccerman(n - 1, 1);
    else
        return FuncAccerman(n - 1, FuncAccerman(n, m - 1));
}

int result = FuncAccerman(2,3);
System.Console.WriteLine(result);
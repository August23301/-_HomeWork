/*
57. Составить частотный словарь элементов двумерного массива. Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.
1, 2, 3
4, 6, 1
2, 1, 6
1 встречается 3 раза
2 встречается 2 раза
3 встречается 1 раз
4 встречается 1 раз
6 встречается 2 раза
*/
int[,] Fill2DArray(int row, int col)
{
    int[,] array = new int[row, col];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
    return array;
}

void Print2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write(array[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}

void Slovar(int[,] array)
{
    int sumOf1 = 0;
    int sumOf2 = 0;
    int sumOf3 = 0;
    int sumOf4 = 0;
    int sumOf5 = 0;
    int sumOf6 = 0;
    int sumOf7 = 0;
    int sumOf8 = 0;
    int sumOf9 = 0;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] == 1) sumOf1++;
            if (array[i, j] == 2) sumOf2++;
            if (array[i, j] == 3) sumOf3++;
            if (array[i, j] == 4) sumOf4++;
            if (array[i, j] == 5) sumOf5++;
            if (array[i, j] == 6) sumOf6++;
            if (array[i, j] == 7) sumOf7++;
            if (array[i, j] == 8) sumOf8++;
            if (array[i, j] == 9) sumOf9++;
        }
    }

    if (sumOf1 > 0) System.Console.WriteLine("1 встречается " + sumOf1 + " раз");
    if (sumOf2 > 0) System.Console.WriteLine("2 встречается " + sumOf2 + " раз");
    if (sumOf3 > 0) System.Console.WriteLine("3 встречается " + sumOf3 + " раз");
    if (sumOf4 > 0) System.Console.WriteLine("4 встречается " + sumOf4 + " раз");
    if (sumOf5 > 0) System.Console.WriteLine("5 встречается " + sumOf5 + " раз");
    if (sumOf6 > 0) System.Console.WriteLine("6 встречается " + sumOf6 + " раз");
    if (sumOf7 > 0) System.Console.WriteLine("7 встречается " + sumOf7 + " раз");
    if (sumOf8 > 0) System.Console.WriteLine("8 встречается " + sumOf8 + " раз");
    if (sumOf9 > 0) System.Console.WriteLine("9 встречается " + sumOf9 + " раз");
}
int[,] myArray = Fill2DArray(3, 3);
Print2DArray(myArray);
Slovar(myArray);

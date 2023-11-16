/*
53. Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
8 4 2 4
5 9 2 3
1 4 7 2
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

void ArraySwap(int[,] array)
{
    int[] temp = new int[array.GetLength(1)];
    for (int i = 0; i < temp.Length; i++)
    {
        temp[i]=array[0,i];
        array[0,i]=array[array.GetLength(0)-1,i];
    }
    for (int i = 0; i < temp.Length; i++)
    {
        array[array.GetLength(0)-1,i]=temp[i];
    }
}

int[,] myArray = Fill2DArray(4, 5);
Print2DArray(myArray);
System.Console.WriteLine();
ArraySwap(myArray);
Print2DArray(myArray);
/*
PrintMatrix(int[,] matrix): Метод для вывода матрицы на экран.
 Он принимает на вход двумерный массив целых чисел matrix и выводит его элементы в виде таблицы.

SortRowsDescending(int[,] matrix): Метод для сортировки строк матрицы по убыванию. 
Он принимает на вход двумерный массив целых чисел matrix и сортирует каждую строку матрицы так, чтобы элементы в каждой строке шли по убыванию.
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

void DescendingArrayRowSort(int[,] arrayToSort)
{
    int temp = 0;
    for (int i = 0; i < arrayToSort.GetLength(0); i++)
    {
        for (int j = 0; j < arrayToSort.GetLength(1); j++)
        {
            for (int k = j + 1; k < arrayToSort.GetLength(1); k++)
            {
                if (arrayToSort[i, j] < arrayToSort[i, k])
                {
                    temp = arrayToSort[i, j];
                    arrayToSort[i, j] = arrayToSort[i, k];
                    arrayToSort[i, k] = temp;
                }
            }
        }
    }
}



int[,] myArray = Fill2DArray(4, 5);
Print2DArray(myArray);
System.Console.WriteLine();
DescendingArrayRowSort(myArray);
Print2DArray(myArray);
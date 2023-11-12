//Поиск элемента по позиции

int[,] Fill2DArray(int row, int col)
{
    int[,] array = new int[row, col];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            array[i, j] = i + j;
        }
    }
    return array;
}

void Print2DArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            System.Console.Write(arr[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}

void FindArrayPositions(int[,] arr, int maxRow, int maxColumn)
{
    System.Console.Write("Введи число строк\t");
    int userRow = int.Parse(Console.ReadLine());
    System.Console.Write("Введи число столбцов\t");
    int userColomn = int.Parse(Console.ReadLine());
    if (userRow >= maxRow || userColomn >= maxColumn)
    {
        System.Console.WriteLine("Подумай еще");
    }
    else
    System.Console.WriteLine(arr[userRow, userColomn]);
}

int[,] newsArr = Fill2DArray(5, 5);
Print2DArray(newsArr);
System.Console.WriteLine();
FindArrayPositions(newsArr, 5, 5);
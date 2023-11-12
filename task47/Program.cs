/*
Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

Внутри класса Answer напишите метод CreateRandomMatrix, который принимал бы числа m и n (размерность массива), а также minLimitRandom и maxLimitRandom, 
которые указывают на минимальную и максимальную границы случайных чисел
Также, задайте метод PrintArray, который выводил бы массив на экран.
Для вывода матрица используйте интерполяцию строк для форматирования числа matrix[i, j] с двумя знаками после запятой (f2) и 
добавления символа табуляции (\t) после каждого элемента матрицы. Таким образом, каждый элемент матрицы будет разделен символом табуляции при выводе.
*/

double[,] CreateRandomMatrix(int rows, int columns, int minLimitRandom, int maxLimitRandom)
{
    double[,] array = new double[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
             array[i, j] = new Random().Next(minLimitRandom,maxLimitRandom) + Math.Round(new Random().NextDouble(), 1);
            //array[i, j] = new Random().Next(minLimitRandom, maxLimitRandom);
        }
    }
    return array;
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write(array[i, j] + " \t");
        }
        System.Console.WriteLine();
    }
}

double[,] randomMatrix = CreateRandomMatrix(5, 5, -10, 10);
PrintArray(randomMatrix);
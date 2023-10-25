/*
Напишите программу для работы с массивом вещественных чисел.

Реализуйте класс ArrayOperations, который содержит следующие статические методы:

FindMax(double[] array): Метод принимает на вход массив вещественных чисел array и возвращает максимальное число из массива.

FindMin(double[] array): Метод принимает на вход массив вещественных чисел array и возвращает минимальное число из массива.

CalcDifferenceBetweenMaxMin(double[] array): Метод принимает на вход массив вещественных чисел array и возвращает разницу между максимальным и минимальным числами в массиве.

PrintArray(double[] array): Метод для вывода массива на экран. Он принимает на вход массив array и выводит его элементы с двумя знаками после запятой через табуляцию.
*/
void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i] + "\t ");
    }
}


double FindMax(double[] array)
{
    double max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
            max = array[i];
    }
    return max;
}

double FindMin(double[] array)
{
    double min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min)
            min = array[i];
    }
    return min;
}

void CalcDifferenceBetweenMaxMin(double[] array)
{
    double result = FindMax(array) - FindMin(array);
    System.Console.Write(result);
}

double[] array = new double[] { 3.22, 7.4, 22.3, 2.11, 7.88 };
PrintArray(array);
FindMax(array);
FindMin(array);
CalcDifferenceBetweenMaxMin(array);


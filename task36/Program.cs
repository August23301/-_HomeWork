/*
Напишите программу, которая находит сумму элементов с нечетными индексами в одномерном массиве целых чисел и выводит результат на экран.

Программа должна иметь метод SumOddElements, который принимает массив целых чисел и возвращает сумму элементов с нечетными индексами в массиве.

Программа должна иметь метод PrintArray, который выводит элементы массива на экран.

При выводе элементы массива должны быть разделены символом табуляции "\t".

Аргументы, передаваемые в метод/функцию:
*/

int[] CreateArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 10);
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i] + " ");
    }
}

void SumOddElements(int[] array)
{
    System.Console.WriteLine();
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 !=0) result= result+array[i];
    }
    System.Console.WriteLine(result);
}

System.Console.Write("задай сайз ");
int userSize = int.Parse(Console.ReadLine());
int[] myArray= CreateArray(userSize);
PrintArray(myArray);
SumOddElements(myArray);
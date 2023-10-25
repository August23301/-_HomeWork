/*
35. Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 
Пример для массива из 5, а не 123 элементов. В своем решении сделайте для 123
[5, 18, 123, 6, 2] -> 1
[1, 2, 3, 6, 2] -> 0
[10, 11, 12, 13, 14] -> 5
*/

int[] NewArray123()
{
    int[] array = new int[123];
    System.Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-30, 120);
        System.Console.Write(array[i] + " ");
    }
    System.Console.WriteLine("]");
    return array;
}

void FindNumbers(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i]>=10 && arr[i]<=99) count+=1;
    }
    System.Console.WriteLine("Колличество чисел, подходящих для данного отрезка "+ count);
}

int[] myArray = NewArray123();
FindNumbers (myArray);
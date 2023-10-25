/*
31. Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.
Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.
*/

int[] FillArray()
{
    int[] array = new int[12];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-9, 9);
        System.Console.Write(array[i] + " ");
    }
    return array;
}

void PlusArray(int[] arr)
{
    int result = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0)
            result += arr[i];
    }
    System.Console.WriteLine();
    System.Console.WriteLine($"Сумма положительных чисел равна {result}");
}

void MinusArray(int[] arr)
{
    int result = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i]<0)
            result+=arr[i];
    }
    System.Console.WriteLine($"Сумма отрицательных чисел равна {result}");
}

int[] userArray = FillArray();
PlusArray(userArray);
MinusArray(userArray);

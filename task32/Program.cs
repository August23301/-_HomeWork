/*
32. Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
[-4, -8, 8, 2] -> [4, 8, -8, -2]
*/

int[] NewArray(int size)
{
    int[] arr = new int[size];
    for (int i = 0; i < size; i++)
    {
        arr[i] = new Random().Next(-10, 11);
        System.Console.Write(arr[i] + " ");
    }
    return arr;
}

void ReverseNumbers(int[] arr)
{
    System.Console.WriteLine();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = arr[i] * -1;
        System.Console.Write(arr[i] + " ");
    }
}

int[] myArray = NewArray(6);
ReverseNumbers(myArray);


/*
37. Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
[1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 36 21
*/

int[] RndArray(int size)
{
    int[] arr = new int[size];
    for (int i = 0; i < size; i++)
    {
        arr[i] = new Random().Next(1, 10);
        System.Console.Write(arr[i] + " ");
    }
    return arr;
}
void Output(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i] + " ");
    }
}
int[] MultiArray(int[] array)
{
    int[] result = new int[array.Length - array.Length / 2];
    int temp = 0;
    for (int i = 0; i < array.Length -array.Length / 2; i++)
    {
        if (i == array.Length - 1- i)      
        {
            result[i]=array[i];
            continue;
        }
        temp = array[i] * array[array.Length - 1 - i];
        result[i] = temp;
    }
    return result;
}

int[] arr = RndArray(5);
System.Console.WriteLine();
int[] arr2 = MultiArray(arr);
Output(arr2);

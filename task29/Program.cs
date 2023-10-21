/*
Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/

int[] RandomArray(int sizeArray, int min, int max)
{
    int[] array = new int[sizeArray];
    for (int i = 0; i < sizeArray; i++)
    {
        array[i] = new Random().Next(min, max);
    }
    return array;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.Write(arr[i] + " ");
    }
}

System.Console.Write("I.NEED.SIZE ");
int userSize = int.Parse(Console.ReadLine());
System.Console.Write("Минимальное значение ");
int userMin = int.Parse(Console.ReadLine());
System.Console.Write("Максимальное значение ");
int userMax = int.Parse(Console.ReadLine());

int[] userArray = RandomArray(userSize, userMin, userMax);
PrintArray(userArray);
/*
Напишите программу, которая подсчитывает количество четных элементов в массиве целых положительных трехзначных чисел и выводит результат на экран.

Программа должна иметь метод CountEvenElements, который принимает массив целых положительных трехзначных чисел и возвращает количество четных элементов в массиве.

Программа должна иметь метод PrintArray, который выводит элементы массива на экран.

При выводе элементы массива должны быть разделены символом табуляции "\t".

Если аргументы командной строки не переданы, программа использует массив по умолчанию, который содержит следующие значения: {100, 102, 105, 166, 283, 764, 300, 499, 133}.
*/

int[] CreateArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 1000);
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

void CountEvenElements(int[] array)
{
    System.Console.WriteLine();
    int count =0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i]%2==0)
        count++;
    }
    System.Console.WriteLine($"Колличество четных эллементов равно {count}");
}

System.Console.WriteLine("Нужен размер массива ");
int araSize = int.Parse(Console.ReadLine());
int[] ara = CreateArray(araSize);
PrintArray(ara);
CountEvenElements(ara);
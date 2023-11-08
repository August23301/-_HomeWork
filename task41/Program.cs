/*
Пользователь вводит с клавы N чисел, посчитайте сколько чисел больше 0 он ввел.
*/
System.Console.Write("Сколько чисел бушь вводить? ");
int size = int.Parse(Console.ReadLine());
int[] myArray = FillArray(size);
PlusNumbers(myArray);
int[] FillArray(int sizeArray)
{
    int[] array = new int[sizeArray]; 
    for (int i = 0; i < sizeArray; i++)
    {
        System.Console.Write("Введи число\t");
        array[i] = int.Parse(Console.ReadLine());
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.WriteLine(array[i] + " ");
    }
}

void PlusNumbers(int[] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i]>0) result++;
    }
    System.Console.WriteLine($"Введено {result} положительных числа");
}

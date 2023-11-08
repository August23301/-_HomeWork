/*
напишите программу, которая перевернет массив 1,2,3,4 - 4,3,2,1
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

void RecurseArray(int[] array)
{
    System.Console.WriteLine();
    for (int i = 0; i < array.Length/2; i++)
    {
        int temp = array[i];
        array[i]=array[array.Length-i-1];
        array[array.Length-i-1]= temp;
    }
}

int[] myArray = CreateArray(4);
PrintArray(myArray);
System.Console.WriteLine();
RecurseArray(myArray);
PrintArray(myArray);

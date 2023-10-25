int[] GetRnd(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(-9, 10);
    }
    return array;
}

void PrintArray(int[] arr)
{
    Console.ForegroundColor = ConsoleColor.Green;
    System.Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Thread.Sleep(100);
        System.Console.Write(arr[i]);
        if (i < arr.Length - 1)
            System.Console.Write(", ");
    }
    Console.ForegroundColor = ConsoleColor.Green;
    System.Console.Write("]");
    Console.ResetColor();
}

bool Numb(int[] arr, int srav)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == srav) return true;
    }
    return false;
}
System.Console.WriteLine("Задай цифру");
int numberUser = int.Parse(Console.ReadLine());

int [] ArrayF = GetRnd(8);
PrintArray(ArrayF);
bool PravdaFalse =Numb(ArrayF, numberUser);
System.Console.WriteLine(PravdaFalse);
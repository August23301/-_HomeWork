void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i] + " ");
    }
}

void CheckingSide(int a, int b, int c)
{
    if (a + b > c && a + c > b && b + c > a && c + b > a)
        System.Console.WriteLine($"Треугольник со сторонами {a},{b},{c} может существовать");
    else
        System.Console.WriteLine($"Треугольник со сторонами {a},{b},{c} НЕ может существовать");

}

System.Console.WriteLine("Введите сторону треугольника 1 ");
int sideA = int.Parse(Console.ReadLine());
System.Console.WriteLine("Введите сторону треугольника 2 ");
int sideB = int.Parse(Console.ReadLine());
System.Console.WriteLine("Введите сторону треугольника 3 ");
int sideC = int.Parse(Console.ReadLine());
System.Console.WriteLine();

CheckingSide(sideA, sideB, sideC);

//int[] array = new int[] { sideA, sideB, sideC };
//PrintArray(array);
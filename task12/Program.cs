/*12.Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому.
Если второе число некратно первому, то программа выводит остаток от деления.
34, 5 -> некратно, остаток 4
16, 4 -> кратно*/

System.Console.WriteLine("Дай-ка мне любое число");
int firstNumber = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Второе тоже надо, а то ничего не получится");
int secondNumber = Convert.ToInt32(Console.ReadLine());

if (firstNumber%secondNumber == 0) {
    System.Console.WriteLine("кайф, они кратны");
}
else {
    int ostatok = firstNumber%secondNumber;
    System.Console.WriteLine($"они не кратны, ostatok budet {ostatok}");
}
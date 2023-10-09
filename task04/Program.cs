/*Внутри класса Answer напишите метод FindMax, который принимает на вход три числа и выдаёт максимальное из этих чисел.
*/

System.Console.WriteLine("1-ое число, давай!");     // ПОЛЬЗОВАТЕЛЬ ВВОДИТ 3 ЧИСЛА
int first_number = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("2-ое число, давай!");
int second_number = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("3-етье число, давай!");
int third_number = Convert.ToInt32(Console.ReadLine());


if (first_number > second_number && first_number > third_number) //Проверка, если первое число большее
{
    System.Console.WriteLine($"Наибольшее число {first_number}");
}
else if (second_number > first_number && second_number > third_number) // Проверка, если вторео число большее
{
    System.Console.WriteLine($"Наибольшее число {second_number}");
}
else //третье число большее
System.Console.WriteLine($"Наибольшее число {third_number}");
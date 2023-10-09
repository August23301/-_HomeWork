/*
Внутри класса Answer напишите метод CompareNumbers, который на вход принимает два числа и выводит, какое число большее, а какое меньшее.

a = 5; b = 7 -> Первое число 5 меньше чем второе число 7

a = 2; b = 2 -> Введенные числа равны 2

a = -3; b = -9 -> Первое число -3 больше чем второе число -9
*/

System.Console.WriteLine("Введи, плз, 1ое число, а");  // ПОЛЬЗОВАТЕЛЬ ВВОДИТ ЧИСЛА
int first_number = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Давай и второе сразу же");
int second_number = Convert.ToInt32(Console.ReadLine());

if (first_number > second_number)   // ТРИ ВЕТОЧКИ, КОТОРЫЕ ПРОВЕРЯЮТ ВВЕДЕННЫЕ ЧИСЛА И ВЫВОДЯТ РЕЗУЛЬТАТ ПОЛЬЗОВАТЕЛЮ (МНЕ)
    System.Console.WriteLine($"{first_number} больше, чем {second_number}");
else if (first_number < second_number)
    System.Console.WriteLine($"{second_number} больше, чем {first_number}");
else if (first_number == second_number)
    System.Console.WriteLine($"{first_number} равен{second_number}");

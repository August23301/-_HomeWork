/* Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго. 
*/

System.Console.WriteLine("Введите 1ое число: ");
int kvadrat_number = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите 2ое число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number*number == kvadrat_number){
    System.Console.WriteLine(kvadrat_number+" является квадратом числа "+number);
}
else {
    System.Console.WriteLine(kvadrat_number+" НЕ является квадратом числа "+number);
}
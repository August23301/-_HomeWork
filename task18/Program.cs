/*
18. Напишите программу, которая по заданному номеру четверти, показывает диапазон
возможных координат точек в этой четверти (x и y).
*/

System.Console.Write ("Задайте номер четверти, плз, а ");
int num = int.Parse(Console.ReadLine());

if (num == 1) {
    Console.WriteLine ("X={1,2,3...}, Y={1,2,3...}");
}

if (num == 2) {
    Console.WriteLine ("X={-1,-2,-3...}, Y={1,2,3...}");
}

if (num == 3) {
    Console.WriteLine ("X={-1,-2,-3...}, Y={-1,-2,-3...}");
}

if (num == 4) {
    Console.WriteLine ("X={1,2,3...}, Y={-1,-2,-3...}");
}

if (num<1 || num>4){
    Console.Write("Указанная четверть не существует в нашей реальности");
}
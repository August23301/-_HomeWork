/*17. Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0
и выдаёт номер четверти плоскости, в которой находится эта точка.
x=34; y=-30 -> 4 
x=2; y=4-> 1
x=-34; y=-30 -> 3*/
 
Console.WriteLine ("Введите Х");
int x = Convert.ToInt32 (Console.ReadLine());

Console.WriteLine ("Введите У");
int y = Convert.ToInt32(Console.ReadLine());

if (x==0 || y==0){
    Console.WriteLine("Введены неверные значения");
}

else if (x>0 && y>0) {
    Console.WriteLine($" При x={x} и у={y} четверть плоскости будет 1");
}

else if (x<0 && y>0) {
    Console.WriteLine($" При x={x} и у={y} четверть плоскости будет 2");
}

else if (x<0 && y<0) {
    Console.WriteLine($" При x={x} и у={y} четверть плоскости будет 3");
}

else if (x>0 && y<0) {
    Console.WriteLine($" При x={x} и у={y} четверть плоскости будет 4");
}







/*
Напишите программу, которая будет выдавать название дня недели по заданному номеру.
3 -> Среда
5 -> Пятница*/

System.Console.WriteLine("Введи номер дня недели, пжлста ");
int number_of_week = Convert.ToInt32(Console.ReadLine());
if (number_of_week == 1) {
    System.Console.WriteLine("понедельник");
}

else if (number_of_week == 2){
    System.Console.WriteLine("вторник");
}

else if (number_of_week == 3){
    System.Console.WriteLine("среда");
}
else if (number_of_week == 4){
    System.Console.WriteLine("четверг");
}
else if (number_of_week == 5){
    System.Console.WriteLine("пятница");
}
else if (number_of_week == 6){
    System.Console.WriteLine("суббота");
}
else if (number_of_week == 7){
    System.Console.WriteLine("воскресенье");
}
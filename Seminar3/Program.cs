// Задача 18. НАпишите программу, которая по заданной четверти выдает диапазон возможных координат в этой четверти
Console.WriteLine ("Задайте четверть 1, 2, 3 или 4: ");
int sqr = Convert.ToInt32(Console.ReadLine());
if (sqr == 1) Console.WriteLine ($"X>0 & y>0");
else if (sqr == 2) Console.WriteLine ($"X>0 & y<0"); 
else if (sqr == 3) Console.WriteLine ($"X<0 & y<0"); 
else if (sqr == 4) Console.WriteLine ($"X>0 & y>0"); 
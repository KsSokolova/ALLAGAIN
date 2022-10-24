// // Задача 18. НАпишите программу, которая по заданной четверти выдает диапазон возможных координат в этой четверти
// Console.WriteLine ("Задайте четверть 1, 2, 3 или 4: ");
// int sqr = Convert.ToInt32(Console.ReadLine());
// if (sqr == 1) Console.WriteLine ($"X>0 & y>0");
// else if (sqr == 2) Console.WriteLine ($"X>0 & y<0"); 
// else if (sqr == 3) Console.WriteLine ($"X<0 & y<0"); 
// else if (sqr == 4) Console.WriteLine ($"X>0 & y>0"); 

// Задача 21. Напишите программу, кот. прнимает на вход координаты 2 точек и находит расстояние между ними в 2d пространстве
// d = √ (х2-х1)*2 + (y2-y1)*2
// Console.WriteLine("Введите x1: ");
// int x1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите y1: ");
// int y1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите x2: ");
// int x2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите y2: ");
// int y2 = Convert.ToInt32(Console.ReadLine());
// double d = Math.Sqrt(Math.Pow(x2-x1,2) + Math.Pow(y2-y1,2));
// Console.WriteLine (Math.Round(d,3));

// // Напишите программу, которая принимает на вход число N и выдает таблицу квадратов чисел от 1 до N
// int start = 1;
// Console.WriteLine ("ВВедите число N: ");
// int end = Convert.ToInt32(Console.ReadLine());
// while (start <= end);
// {
//     Console.WriteLine(start * start);
//     start++;
// }
// через цикл FOR:

// int end = Convert.ToInt32(Console.ReadLine());
// for (int start = 1; start<=end; start++);
// {
//     Console.WriteLine(start*start);
// }

int end = 10;
for (int start = 1; start < end; start+=2)
{
    Console.WriteLine(start);
}
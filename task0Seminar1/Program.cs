// Напишите программу, которая на вход принимает число и выдает его квадрат
// Console.Write ("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int square = number*number;
// Console.WriteLine (square);

// Задача 2. Напишите программу, кот на вход принимает 2 числа и проверяет, является ли первое число квадратом второго
// Console.WriteLine ("Введите число А: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine ("Введите число B: ");
// int b = Convert.ToInt32(Console.ReadLine());
// if (a == b*b) Console.WriteLine ($"da");
// else Console.WriteLine ($"net");


// Напишите программу, которая будет выдавать название дня недели по заданному номеру
// Console.WriteLine ("Напишите цифру дня недели: ");
// int number = Convert.ToInt32(Console.ReadLine());
// if (number == 1) Console.WriteLine ($"Это понедельник");
// if (number == 2) Console.WriteLine ($"Это вторник"); 
// if (number == 3) Console.WriteLine ($"Это среда");
// if (number == 4) Console.WriteLine ($"Это чт");
// if (number == 5) Console.WriteLine ($"Это пт");
// if (number == 6) Console.WriteLine ($"Это сб");
// if (number == 7) Console.WriteLine ($"Это вск");

// НАпишите программу, кот на вход принимает число N, а на выходе дает все целые числа от -N до N
Console.WriteLine ("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int count = number *(-1);
while (count<=number)
{
    Console.Write(count + " ");
    count++;
}

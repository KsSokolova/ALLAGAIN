//7. Создайте программу, которая на вход принимает трехзначное число, а на выходе показывает третью цифру этого числа
// Console.WriteLine("Введите трехзначное число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int thirdDigit = 0;
// thirdDigit = number%10;
// Console.WriteLine (thirdDigit);

// Задача 2. Напишите программу, которая на вход принимает 2 числа и выдает, какое больше 
// Console.WriteLine("Введите первое число: ");
// int number1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число: ");
// int number2 = Convert.ToInt32(Console.ReadLine());
// int max = number1;
// if (number2>number1) max = number2;
// Console.WriteLine($"max {max}");

//Задача 4. Напишите программу, которая на вход принимает 3 числа и выдает максимальное
// Console.WriteLine("Введите первое число: ");
// int number1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число: ");
// int number2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите третье число: ");
// int number3 = Convert.ToInt32(Console.ReadLine());
// int max = number1;
// if (number2>number1) max = number2;
// if (number3>number2) max = number3;
// Console.WriteLine($"max {max}");

//Задача 6. Напишите программу, кот на вход принимает число и выдает, является ли оно четным
// Console.WriteLine("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// if (number%2==0) Console.WriteLine($"четное");
// else Console.WriteLine($"не четное");

// Задача 8. Напишите программу, которая на вход принимает число N, а на выходе показывает все четные числа от 1 до N
// Console.WriteLine("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int x = 1;
// while (x<=number) 
// {
//     if (x%2==0)
//     Console.Write(x + " ");
//     x++;
// }

// // Задача 9. Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа
// int number = Convert.ToInt32(Console.ReadLine());
// int firstDigit = number/10;
// int secondDigit = number%10;
// if (firstDigit>secondDigit) Console.WriteLine (firstDigit);
// else Console.WriteLine(secondDigit);

// //1.Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа. 456 -> 46 782 -> 72 918 -> 98
// Console.WriteLine("Введите трехзначное число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int firstDigit = number/100;
// int thirdDigit = number%10;
// Console.WriteLine($"{firstDigit}{thirdDigit}");

// 2. Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе
// число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4 16, 4 -> кратно
Console.WriteLine("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
if (number1%number2==0) Console.WriteLine($"кратное");
else Console.WriteLine(number1%number2);

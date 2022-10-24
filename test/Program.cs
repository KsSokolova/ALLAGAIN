// Программа, кот выдает четные числа без проверки на четность
// int end = 10;

// for (int start = 1; start < end; start+=2)
// {
//     Console.WriteLine(start);
// }

// Задача 19. Напишите программу, кот принимает на вход пятизначное число и проверяет, является ли оно палиндромом
// 14212 - нет    23432 да
Console.WriteLine("Введите пятизначное число: ");
string test = Console.ReadLine();
if ((test[0]==test[4]) && (test[1]==test[3])) Console.WriteLine ($"да");
else Console.WriteLine ($"нет");
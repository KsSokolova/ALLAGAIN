// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5  782 -> 8   918 -> 1
// Console.WriteLine("Введите трехзначное число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int x = number/10;
// int y = x%10;
// Console.WriteLine(y);

//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5     78 -> третьей цифры нет      32679 -> 6

Console.WriteLine("Задача 13. Введите число: ");
string? test = Console.ReadLine();
if (test.Length<3){
    Console.WriteLine($"Третьей цифры нет");
}
else 
{
Console.WriteLine($"{test[2]}");
}

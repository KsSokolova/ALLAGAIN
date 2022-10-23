//7. Создайте программу, которая на вход принимает трехзначное число, а на выходе показывает третью цифру этого числа
Console.WriteLine("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int thirdDigit = 0;
thirdDigit = number%10;
Console.WriteLine (thirdDigit);

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Write("Введите пятизначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
int num1 = num;
int num2 = num;
int num4 = num;
int num5 = num;

if (num > 10000 && num < 100000)
{
    num1 = num1 / 10000;
    num5 = num5 % 10;
    num2 = num2 / 1000 % 10;
    num4 = num4 / 10 % 10;
    if (num1 == num5 & num2 == num4) Console.WriteLine($"Число {num} -> Да");
    else Console.WriteLine($"{num} -> Нет");
}
else Console.WriteLine($"Число должно быть пятизначным!");
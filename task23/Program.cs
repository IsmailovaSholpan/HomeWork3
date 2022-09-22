// Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Clear();
Console.Write("Введите число:  ");
int num = Convert.ToInt32(Console.ReadLine());
int count = 1;

void Digite(int num1, int count1)
{
    while (count1 <= num1)
    {
        Console.Write((count1*count1*count1) + ", ");
        count1 = count1 + 1; 
    }
};
Digite(num, count);

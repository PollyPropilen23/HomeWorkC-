/*
// Задача 1. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
int FindPolindrom (int num)
{   int polindrom = 0;
    while (num >= 10)
    {
        polindrom = polindrom *10 + num % 10;
        num = num/10;
    }
    polindrom = polindrom * 10 + num;
    return polindrom;
}   

Console.Write("Введите пятизначное число: ");
int num = Convert.ToInt32(Console.ReadLine());

int res = FindPolindrom(num);

if (num == res)
Console.Write($"Число {num} полиндром");
else
Console.Write($"Число {num} не полиндром");
*/

/*
// Задача 3. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N

void Cube (int num)
{
    int current = 1;
    while (current <= num)
    {
       int cube = current * current * current;
       Console.Write (cube + " ");
       current++;
    }
}

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
Cube(num);
*/
//----------------------HomeWork004--------------------------
/*
// Задача 1. Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

int Degree(int a, int b)
{
    int result = a;
    int current = 2;
    while (current <= b)
    {
        result *= a;
        current++;
    } 
    return result;
}

Console.Write("Введите натуральное число A ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите натуральное число B ");
int b = Convert.ToInt32(Console.ReadLine());

Console.Write($"Число A в степени B равно {Degree(a,b)}");
*/
/*
// Задача 2. Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int Summa(int num)
{
    int result = 0;
    while (num > 10)
    {
        result += num % 10;
        num /= 10;
    }
    result += num;
    return result;
}

Console.Write("Введите число ");
int num = Convert.ToInt32(Console.ReadLine());

Console.Write($"Сумма цифр числа {num} равна {Summa(num)}");
*/
/*
// Задача 3. Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int [] CreateArray (int n)
{
    int [] array = new int[n];
    for (int i = 0; i < n; i++)
    {
        Console.Write($"Введите {i+1}-й элемент массива: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}
void PrintArray (int [] array)
{
    Console.Write ("[");
    for ( int i=0; i< array.Length; i++)
        Console.Write($"{array[i]}, ");
    Console.WriteLine("\b\b]");

}
Console.Write("Введите количество элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int [] array = CreateArray(n);
PrintArray(array);
*/
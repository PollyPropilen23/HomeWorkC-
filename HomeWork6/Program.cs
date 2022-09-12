//----------------------HomeWork006--------------------------
// Задача 1. Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
/*
int [] CreateArray (int n)
{
    int [] array = new int[n];
    for (int i = 0; i < n; i++)
    {
        Console.Write($"Введите {i+1}-е число: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}
void PrintArray (int [] array)
{

    for ( int i=0; i< array.Length; i++)
        Console.Write($"{array[i]} ");
        Console.WriteLine();

}
int NegativeQuant (int [] array)
{
    int count=0;
    for (int i=0;i<array.Length;i++)
    {
        if (array[i]<0) count++;
    }
    return count;
}

Console.Write("Введите М: ");
int n = Convert.ToInt32(Console.ReadLine());
int [] array = CreateArray(n);
PrintArray(array);
Console.Write($"Среди введенных чисел {NegativeQuant(array)} отрицательных");
*/
// Задача 2. Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
/*
void FindCross(double k1, double b1, double k2, double b2)
{
    double x= Math.Round((b2-b1)/(k1-k2),2);
    double y = Math.Round(k1*x-b1,2);
    Console.Write($"Точкой пересечения прямых y={k1}x+{b1} и у={k2}x+{b2} является точка А({x} ; {y})");
}
Console.Write("Введите значение k1 ");
double k1= Convert.ToDouble(Console.ReadLine());
Console.Write("Введите значение b1 ");
double b1= Convert.ToDouble(Console.ReadLine());
Console.Write("Введите значение k2 ");
double k2= Convert.ToDouble(Console.ReadLine());
Console.Write("Введите значение b2 ");
double b2= Convert.ToDouble(Console.ReadLine());
FindCross(k1,b1,k2,b2);
*/
//-------------------------HomeWork009----------------------
// Задача 1. Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
/*
void ShowNumber (int m, int n)
{
    Console.Write (m+" ");
    if (m < n) ShowNumber(m+1,n);
    if (n < m) ShowNumber (m-1,n);
}
Console.Write("Введите начало интервала m= ");
int m= Convert.ToInt32(Console.ReadLine());
Console.Write("Введите конец интервала n= ");
int n= Convert.ToInt32(Console.ReadLine());
ShowNumber(m,n);
*/

// Задача 2. Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
/*
int FindSum (int m, int n)

{   
    int min =0;
    int max=0;
    if(Math.Max(m,n) != Math.Min(m,n))
        {   min = Math.Min(m,n);
            max= Math.Max(m,n);
            return FindSum(min+1,max) + min;
        }
    else return m;

}
Console.Write("Введите начало интервала m= ");
int m= Convert.ToInt32(Console.ReadLine());
Console.Write("Введите конец интервала n= "); 
int n= Convert.ToInt32(Console.ReadLine());
Console.Write(FindSum(m,n));
*/

// Задача 3.  Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
/*
int Akkerman (int m, int n)
{
    if (m==0) return n+1;
    if (m>0 && n==0) return Akkerman(m-1,1);
    if (m>0 && n>0) return Akkerman(m-1,Akkerman(m,n-1));
    return 0;
}
Console.Write("Введите начало интервала m= ");
int m= Convert.ToInt32(Console.ReadLine());
Console.Write("Введите конец интервала n= "); 
int n= Convert.ToInt32(Console.ReadLine());
Console.Write(Akkerman(m,n));
*/
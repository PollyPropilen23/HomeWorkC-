//______________HomeWork002______________
/*
// Задача 1. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

int SecondNum( int num)
{ int res = num/10 %10;
return res;}

Console.Write ("Введите трехзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
int res = SecondNum(num);
Console.Write ($"Вторая цифра числа {num} это {res} ");
*/

/*
//Задача 2. Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

void ThirdNum(int num)
{
    if ( num < 100)
        Console.WriteLine($"Третьей цифры в числе {num} нет");
    else
        { int memory = num; 
        while (num >= 1000)
                {
                num /= 10;
                };
        int res = num % 10;
        Console.Write($"Третья цифра числа {memory} это {res}");
        };
};
    

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
ThirdNum(num);
*/
/*
// Задача 3. Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

bool Week(int num)
{
    if (num < 6)
    return true;
    else
    return false;
}

Console.Write("Введите число от 1 до 7, соотвествующее дню недели: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num < 8)
 {bool res = Week(num);
 if (res)
    {Console.WriteLine($"День недели соотвествующий номеру {num} является будним");}
    else 
    {Console.WriteLine($"День недели соотвествующий номеру {num} выходной");}
}
else
 {Console.Write("Дня недели соотвествующего данному числу нет");};
*/

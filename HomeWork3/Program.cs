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
// Задача 2. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

double Distance (double xa, double ya, double za, double xb, double yb, double zb)
{
    double sumQuad = Math.Pow((xb-xa),2) + Math.Pow((yb-ya),2) + Math.Pow((zb-za),2);
    double dist = Math.Sqrt(sumQuad);
    return dist;
}

Console. WriteLine ("Введите значение х для точки А");
double xa = Convert.ToDouble(Console.ReadLine());

Console. WriteLine ("Введите значение y для точки А");
double ya = Convert.ToDouble(Console.ReadLine());

Console. WriteLine ("Введите значение z для точки А");
double za = Convert.ToDouble(Console.ReadLine());

Console. WriteLine ("Введите значение х для точки B");
double xb = Convert.ToDouble(Console.ReadLine());

Console. WriteLine ("Введите значение y для точки B");
double yb = Convert.ToDouble(Console.ReadLine());

Console. WriteLine ("Введите значение z для точки B");
double zb = Convert.ToDouble(Console.ReadLine());

double dist = Distance(xa,ya,za,xb,yb,zb);

Console.Write("Расстоние от точки А до точки В равно " + dist);
*/

/*
// Задача 3. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N

void Cube (int num)
{
    int current = 1;
    while (current <= num)
    {
       double cube = Math.Pow(current,3);
       Console.Write (cube + " ");
       current++;
    }
}

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
Cube(num);
*/


// Классаная задача
/*
void chetvert (int nom)
{
    if (nom == 1)
    Console.WriteLine("В первой четверти значения по оси абсцис и ординат больше нуля");
    if (nom == 2)
    Console.WriteLine("Во второй четверти значения по оси абсцис меньше нуля, по оси ординат больше нуля");
    if (nom == 3)
    Console.WriteLine("В третьей четверти значения по оси абсцис и ординат меньше нуля");
    if (nom == 4)
    Console.WriteLine("В четвертой четверти значения по оси абсцис больше нуля, а по оси ординат меньше нуля");
    if (nom > 4 || nom < 1)
    Console.WriteLine("Нет четверти, соответствующей введенному числу");

}

Console.Write("Введите номер четверти ");
int nom = Convert.ToInt32(Console.ReadLine());

chetvert(nom);
*/
//------------------HomeWork003---------------------------

// Задача 1. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
/*
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


// Второй способ через bool

/*
bool Polindrom(int num)
{
    int mem = num;
    int backward = 0;

    while (num >= 10)
    {
        backward = backward *10 + num % 10;
        num = num/10;
    }
    backward = backward *10 + num;

    if (mem == backward)
    return true;
    else
    return false;
}

Console.Write("Введите пятизначное число: ");
int num = Convert.ToInt32(Console.ReadLine());

bool res = Polindrom(num);

if (res)
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

Console.Write($"Расстоние от точки А({xa}, {ya}, {za}) до точки В({xb}, {yb}, {zb}) равно " + dist);
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



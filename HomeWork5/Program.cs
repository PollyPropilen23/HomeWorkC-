//-----------------------------HomeWork005--------------------------------
/*
// Задача 1. Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

int [] CreateRandomArray (int size)
{
     int [] array = new int [size];
     for (int i=0; i<size; i++)
         array[i] = new Random().Next(100,1000);
     return array;
};

void PrintArray(int [] array)
{
    for (int i=0; i< array.Length; i++)
    Console.Write($"{array[i]} ");
    Console.WriteLine();

};

int EvenNum (int [] array)
{
    int num=0;
    for (int i=0; i<array.Length; i++)
    {
        if (array[i]%2 == 0)
            num ++;
    }
    return num;
};

Console.Write ("Задайте размер массива ");
int size = Convert.ToInt32(Console.ReadLine());
int [] array = CreateRandomArray(size);
PrintArray(array);
Console.WriteLine ($"Количество четных чисел в массиве равно {EvenNum(array)}");
*/
/*
// Задача 2. Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

int [] CreateNewArray (int size, int min, int max)
{
    int [] randArray = new int [size];
    for (int i=0; i<size; i++)
        randArray[i] = new Random().Next(min,max+1);
    return randArray;
};

void ShowArray (int [] array)
{
    for (int i=0; i<array.Length;i++)
        Console.Write(array[i]+ " ");
    Console.WriteLine();
};

int Summa (int [] array)
{
    int sum=0;
    for (int i = 1; i< array.Length; i+= 2)
        sum += array[i];
    return sum;
};

Console.Write ("Задайте размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write ("Задайте минимальное значение ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write ("Задайте максимальное значение ");
int max = Convert.ToInt32(Console.ReadLine());
int [] array = CreateNewArray(size,min,max);
ShowArray(array);
Console.Write($"Сумма элементов с нечетным индексом равна {Summa(array)}");
*/
/*
// Задача 3. Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

double [] CreateDoubleArray (int size, int min, int max)
{
    double [] array = new double [size];
    for (int i=0; i<size; i++)
        array[i] = Math.Round(new Random().Next(min,max) + new Random().NextDouble(), 2);
    return array;
};
void ShowArray (double [] array)
{
    for (int i=0; i<array.Length; i++)
        Console.Write(array[i]+ "  ");
    Console.WriteLine();
};
double MaxMin (double [] array)
{
    double min = array[0];
    double max = array[1];
    for (int i=0; i< array.Length; i++)
        if (array[i]>max) max = array[i];
        else
        {
            if (array[i]<min) min = array[i];
        }
    double result = Math.Round(max - min,2);
    return result;
};

Console.Write("Введите размер массива ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное значение массива ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение массива ");
int max = Convert.ToInt32(Console.ReadLine());
double [] array = CreateDoubleArray(size,min,max);
ShowArray(array);
Console.Write($"Разница между максимумом и минимумом массива равна {MaxMin(array)}");
*/
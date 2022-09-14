//----------------------------HomeWork007---------------------------
// Задача 1. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
/*
double [,] NewRandomArray ()
{
    Console.Write("Введите количество строк m= ");
    int m= Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите количество столбцов n= ");
    int n= Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите минимальное значение элемента массива ");
    int min = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите максимальное значение элемента массива ");
    int max = Convert.ToInt32(Console.ReadLine());

    double [,] newArray = new double [m,n];

    for (int i=0; i<m; i++)
        for (int j=0; j<n; j++)
            newArray[i,j] = Math.Round(new Random().Next(min,max) + new Random().NextDouble(),2);
    return newArray;
}
void ShowDoubleArray (double [,] array)
{
    for (int i=0; i<array.GetLength(0); i++)
    {
        for (int j=0; j<array.GetLength(1); j++)
            Console.Write (array[i,j]+ " ");
        Console.WriteLine();
    }
    Console.WriteLine();
}    

double [,] myArray = NewRandomArray();
ShowDoubleArray(myArray);
*/

// Задача 2. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
/*
int [,] NewArray()
{
    Console.Write("Введите количество строк n= ");
    int n= Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите количество столбцов m= ");
    int m= Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите минимальное значение элемента массива ");
    int min = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите максимальное значение элемента массива ");
    int max = Convert.ToInt32(Console.ReadLine());

    int [,] array = new int [n,m];
    for (int i=0; i<n; i++)
        for (int j=0; j<m; j++)
            array[i,j]= new Random().Next(min,max+1);
    return array;  

}

void ShowArray (int [,] array)
{
    for (int i=0; i<array.GetLength(0); i++)
    {
        for( int j=0; j<array.GetLength(1); j++)
            Console.Write(array[i,j]+" ");
        Console.WriteLine();
    }
    Console.WriteLine();

}
void FindElement (int [,] array)
{
    Console.Write("Введите номер строки элемента, который Вы хотели бы увидеть ");
    int i= Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите номер столбца элемента, который Вы хотели бы увидеть ");
    int j= Convert.ToInt32(Console.ReadLine());    

    if (i<= array.GetLength(0) & j<= array.GetLength(1))
        Console.WriteLine($"Элемент массива с координатами [{i};{j}] равен {array[i-1,j-1]}");
    else
        Console.WriteLine("Такого элемента массива не существует");
}

int [,] myArray = NewArray();
ShowArray(myArray);
FindElement(myArray);
*/
// Задача 3. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
/*
int [,] NewArray()
{
    Console.Write("Введите количество строк n= ");
    int n= Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите количество столбцов m= ");
    int m= Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите минимальное значение элемента массива ");
    int min = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите максимальное значение элемента массива ");
    int max = Convert.ToInt32(Console.ReadLine());

    int [,] array = new int [n,m];
    for (int i=0; i<n; i++)
        for (int j=0; j<m; j++)
            array[i,j]= new Random().Next(min,max+1);
    return array;  

}
void Show2dArray (int [,] array)
{
    for (int i=0; i<array.GetLength(0); i++)
    {
        for( int j=0; j<array.GetLength(1); j++)
            Console.Write(array[i,j]+" ");
        Console.WriteLine();
    }
    Console.WriteLine();

}
void ShowResaltArray (double [] array)
{
    for ( int i=0; i< array.Length; i++)
        Console.Write($"{array[i]} ");
        Console.WriteLine();
}
double [] FindAverage(int [,] array)
{
    int size = array.GetLength(1);
    double [] resultArray = new double [size];
    
    for (int j=0; j< size; j++)
        {   
            int sum =0;
            for (int i=0; i< array.GetLength(0); i++)
                sum += array [i,j];
            double average = (double) sum/array.GetLength(0);
            resultArray[j]=Math.Round(average,2);  
        }
    return resultArray;
}


int [,] myArray = NewArray();
Show2dArray(myArray);
double [] resaltArray= FindAverage(myArray);
Console.WriteLine("Среднее арифметическое каждого столбца равно:");
ShowResaltArray(resaltArray);
*/
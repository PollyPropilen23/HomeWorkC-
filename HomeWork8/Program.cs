//--------------------------HomeWork008--------------------------
// Задача 1. Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
/*
int [,] CreateNew2dArray()
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

int [,]  NewArrayRowMinToMax (int [,] arr)
{
    for (int i=0; i< arr.GetLength(0); i++)
        for (int j=0; j< arr.GetLength(1); j++)
            for (int k=0; k< arr.GetLength(1)-1-j; k++)
                if (arr[i,k]<arr[i,k+1])
                {
                    int temp= arr[i,k];
                    arr[i,k] = arr[i,k+1];
                    arr[i,k+1] = temp;
                }
 
    return arr;
}

int [,] myArr = CreateNew2dArray();
Show2dArray (myArr);
Show2dArray (NewArrayRowMinToMax(myArr));

*/

// Задача 2. Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
/*
int [,] CreateNew2dArray()
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

int [] SumOfRowsArray (int [,] arr)
{
    int [] sumArr = new int [arr.GetLength(0)];
    
    for (int i=0; i < arr.GetLength(0); i++)
    {   
        int sum =0;
        for (int j=0; j<arr.GetLength(1); j++)
            sum+= arr[i,j];
        sumArr[i]= sum;
    }
    return sumArr;
}

void FindMinRowNumber (int []arr)
{
    int min = arr[0];
    int minRow =0;
    for(int i=1; i<arr.Length; i++)
        if (arr[i]<min)
            {
                min = arr [i];
                minRow =i;
            }
    
    Console.Write($" Номер строки с минимальной суммой элементов {minRow+1}");
}

int [,] myArr = CreateNew2dArray();
Show2dArray(myArr);
FindMinRowNumber(SumOfRowsArray(myArr));
*/
// Задача 3.Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
/*
int [,] CreateNew2dArray()
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

int [,] ResultMultiMatrix (int [,] arr1, int [,] arr2)
{
        int [,] resMatrix = new int [arr1.GetLength(0), arr1.GetLength(1)];
        for (int i=0; i< arr1.GetLength(0); i++)
            for (int j=0; j< arr2.GetLength(1); j++)
                {
                    resMatrix[i,j] = 0;
                    for (int k=0; k< arr1.GetLength(1); k++)
                        resMatrix[i,j] += (arr1[i,k]*arr2[k,j]);
                }
        return resMatrix;

}

Console.WriteLine ($"Введите величины для создания первой матрицы ");
int [,] arr1 = CreateNew2dArray();
Console.WriteLine ($"Введите величины для создания второй матрицы ");
int [,] arr2 = CreateNew2dArray();

if (arr1.GetLength(1) == arr2.GetLength(0))
{
    Console.WriteLine("Первая матрица: ");
    Show2dArray(arr1);
    Console.WriteLine("Вторая матрица: ");
    Show2dArray(arr2);
    int [,] result = ResultMultiMatrix(arr1,arr2);
    Console.WriteLine("Результирующая матрица: ");
    Show2dArray(result);
}
else
    Console.WriteLine($"Матрицы не согласованы.Количество столбцов первой матрицы и количество строк второй должны быть одинаковы");
*/

// Задача 4. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
/*
int [,,] MatrixWithDoubleNum3D(int n,int m,int l)
{
    int [,,] array = new int [n,m,l];
    int min = 10;
    int count =0;
        for (int i=0; i<n; i++)
            for (int j=0; j<m; j++)
                for(int k=0; k<l; k++)
                    {
                        array[i,j,k]= min+count;
                        count++;
                    }
                        
    return array;  

}

void Show3dArray (int [,,] array)
{
    for (int k=0; k<array.GetLength(2); k++)
    {
        Console.WriteLine($"{k+1}-я странница массива");
        for (int i=0; i<array.GetLength(0); i++)
        {
            for( int j=0; j<array.GetLength(1); j++)
                Console.Write(array[i,j,k]+" ");
            Console.WriteLine();
        }
        Console.WriteLine();
    }
    
}

Console.Write("Введите количество строк n= ");
int n= Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов m= ");
int m= Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество страниц l= ");
int l= Convert.ToInt32(Console.ReadLine());

if (n*m*l < 89)
{
    int [,,] myArr = MatrixWithDoubleNum3D(n,m,l);
    Show3dArray(myArr);
}
else
    Console.WriteLine("Слишком большой размер матрицы для заполнения неповторяющимися числами");
*/

// Задача 5. Напишите программу, которая заполнит спирально массив 4 на 4.

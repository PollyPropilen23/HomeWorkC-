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

// Поменять местами строки и столбцы двумерного массива
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
*/
/*
int [,] ChangeRowsAndColums (int [,] arr)
{
    if (arr.GetLength(0) == arr.GetLength(1))
    {
        for (int i =0; i<arr.GetLength(0)-1;i++)
            for (int j=1+i; j< arr.GetLength(1);j++)
            {
                int temp = arr[i,j];
                arr[i,j] = arr[j,i];
                arr[j,i] = temp;
            }
        
    }
    return arr;
    
}

int [,] myArr = CreateNew2dArray();
Show2dArray(myArr);
Show2dArray(ChangeRowsAndColums(myArr));
*/
/*
int [,] ArrayWithoutMinElement (int [,] arr)
{
    int minRow = 0;
    int minColumn = 0;
    int min = arr[minRow,minColumn];

    for (int i=0; i<arr.GetLength(0); i++)
        for (int j=0; j<arr.GetLength(1); j++)
            if (arr[i,j]<min)
            {
                min = arr[i,j];
                minRow = i;
                minColumn =j;
            }

    Console.WriteLine($" Минимальное число {min} столбец {minColumn+1} строка {minRow+1}");
    Console.WriteLine();
    int [,] newArr = new int [arr.GetLength(0)-1,arr.GetLength(1)-1];
    int n=0;
    int m=0;

    for (int i=0; i<arr.GetLength(0)-1;i++)
        for (int j=0; j<arr.GetLength(1)-1; j++)
        {
            if (i < minRow) 
                n = i;
            else n = i+1;
            if (j < minColumn)
                m = j;
            else m = j+1;

            newArr[i,j]=arr[n,m];

            
        }
    return newArr;
}
int [,] myArr = CreateNew2dArray();
Show2dArray(myArr);
Show2dArray(ArrayWithoutMinElement(myArr));
*/

string [] CreateStringArray (int n)
{
    string [] arr = new string [n];
    for (int i=0; i<n; i++)
    {
        Console.Write($"Введите {i+1}-й элемент строчного массива: ");
        arr[i] = Console.ReadLine(); 
    }
    return arr;
}

void ShowStringArray (string [] arr)
{
    for (int i=0; i<arr.Length; i++)
    Console.Write(arr[i]+" | ");
}

int FindSize (string [] array, int count)
{
    int size = 0;
    for (int i=0; i< array.Length; i++)
        if (array[i].Length <= count) size++;
    return size;
}

string [] CreateArrayOfShortStrings (string [] array, int size, int count)
{   string [] shortArr = new string [size];
    int j=0;
        for (int i=0; i< array.Length; i++)
            if (array[i].Length <= count) 
            {
                shortArr[j] = array[i];
                j++;
            }
        return shortArr;
}


Console.Write("Введите количество элементов массива = ");
int n = Convert.ToInt32(Console.ReadLine());
if (n<=0) 
    Console.Write("Размер массива должен быть больше 0");
else
{      
    string [] arr = CreateStringArray(n);
    ShowStringArray(arr);
    Console.WriteLine();
}
Console.Write("Введите максимальную величену строк для создания нового массива = ");
int count = Convert.ToInt32(Console.ReadLine());
int size = FindSize( arr,count);
string [] newArr = CreateArrayOfShortStrings(arr);
ShowStringArray(newArr);
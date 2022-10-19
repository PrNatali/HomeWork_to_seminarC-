// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
/*
int [,] Create2dArray (int a, int b, int minVal, int maxVal)
{
    int [,]myArr = new int [a, b];
    for(int i = 0; i < a; i++)
        for(int j = 0; j< b; j++)
            myArr[i,j] = new Random().Next(minVal, maxVal + 1);
    return myArr;
}

void Print2dArray (int [,]newArray)
{
    for(int i = 0; i< newArray.GetLength(0); i++)
    {
        for(int j = 0; j<newArray.GetLength(1); j++)
            Console.Write(newArray[i,j] + " ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] SortingFromMax(int[,]myArr)
{
    int temp = 0;
    for(int i=0; i<myArr.GetLength(0); i++)
        for(int j=0; j< myArr.GetLength(1) - 1; j++)
            for(int k = j+1; k<myArr.GetLength(1); k++)
                if(myArr[i,j] < myArr[i,k])
                {
                    temp = myArr[i,k];
                    myArr[i,k] = myArr[i,j];
                    myArr[i,j] = temp;
                }
    return myArr;
}


Console.Write("Enter quantity rows: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter quantity columns: ");
int col = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter value of the minimal: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter value of the maximal: ");
int max = Convert.ToInt32(Console.ReadLine());

int [,]new2dArr = Create2dArray (row, col, min, max);
Print2dArray(new2dArr);
Print2dArray(SortingFromMax(new2dArr));
*/
//Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
/*
int [,] Create2dArray (int a, int b, int minVal, int maxVal)
{
    int [,]myArr = new int [a, b];
    for(int i = 0; i < a; i++)
        for(int j = 0; j< b; j++)
            myArr[i,j] = new Random().Next(minVal, maxVal + 1);
    return myArr;
}

void Print2dArray (int [,]newArray)
{
    for(int i = 0; i< newArray.GetLength(0); i++)
    {
        for(int j = 0; j<newArray.GetLength(1); j++)
            Console.Write(newArray[i,j] + " ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

int MinimalRow (int[,]array1, int maxVal, int column)
{
    int row = 0;
    int min = maxVal * column; //сравниваю с максимально возможным значением

    for(int i = 0; i < array1.GetLength(0); i++)
    {   
        int sum = 0;
        for(int j = 0; j<array1.GetLength(1); j++)
            sum += array1[i,j];
        Console.WriteLine($"sum row = {sum}");
        
        if(sum < min)
        {
            min = sum;
            row = i+1; //номер строки для пользователя
        }
    }
    return row;
}

Console.Write("Enter quantity rows: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter quantity columns: ");
int col = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter value of the minimal: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter value of the maximal: ");
int max = Convert.ToInt32(Console.ReadLine());

int [,]new2dArr = Create2dArray (row, col, min, max);
Print2dArray(new2dArr);
Console.WriteLine(MinimalRow(new2dArr, max, col));

*/
//Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
//Массив размером 2 x 2 x 2
/*
int [,,] NewRandom3dArr ()
{
    Console.Write("enter quantity of page: ");
    int pages = Convert.ToInt32(Console.ReadLine());
    Console.Write("enter quantity of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("enter quantity of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("enter of value minimal: ");
    int minVal = Convert.ToInt32(Console.ReadLine());
    Console.Write("enter of value maximal: ");
    int maxVal = Convert.ToInt32(Console.ReadLine());

    int [,,] newArr = new int [pages, rows, columns];

    for (int k = 0; k < pages; k++)
        for(int i = 0; i < rows; i++)
            for(int j = 0; j < columns; j++)
            newArr[k,i,j] = new Random().Next(minVal,maxVal +1);
    return newArr;        
}
void Print3dArray (int [,,] array)
{
    for (int k = 0; k < array.GetLength(0); k++)
    {
        Console.WriteLine($"page {k+1}");
        for(int i = 0; i < array.GetLength(1); i++)
        {
            for(int j = 0; j < array.GetLength(2); j++)
                Console.Write($"{array[k,i,j]} ({k},{i},{j})  ");
            Console.WriteLine();
        }
    }
Console.WriteLine();
}

int[,,]myArr = NewRandom3dArr();
Print3dArray(myArr);
*/
/*
// Заполнить массив по спирали
int [,] NewSpir2dArr ()
{
    Console.Write("enter size of array: ");
    int size = Convert.ToInt32(Console.ReadLine());
    int [,] newArr = new int [size, size];
    int value = 1;
    for(int i = 0; i < size; i++)
    {
       for(int j = 0; j < size; j++)
        value +=1;
    }
            for(int j = 0; j<size - 1; j++ )
            {
                for(int i = 0; i< size -1; i++)
                    value +=1;
            }
    return newArr;
}
       
    

    
    

   
   Console.Write("enter quantity of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("enter quantity of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());

    int [,] newArr = new int [rows, columns];

    for (int i = 0; i < rows; i++)
    
        for(int j = 0; j < columns; j++)
        {
            newArr[i,j] += 1;
        
    
            rows --;
            columns --;
        
            for (int k = j; k < rows; k++)
            {
                for(int n =i; n < columns; n++)
                newArr[i,j] += 1;
            }
        }
    
    return newArr;        
}
*/
/*
void Print2dArray (int [,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
       for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j]+ " ");
    Console.WriteLine();
    }
Console.WriteLine();
}

int[,]myArray = NewSpir2dArr();
Print2dArray(myArray);

*/

//Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
/*
int [,] NewRandom2dArr ()
{
    int size = 2;

    Console.Write("enter of value minimal: ");
    int minVal = Convert.ToInt32(Console.ReadLine());
    Console.Write("enter of value maximal: ");
    int maxVal = Convert.ToInt32(Console.ReadLine());

    int [,] newArr = new int [size, size];

    for (int i = 0; i < size; i++)
        for(int j = 0; j < size; j++)
            newArr[i,j] = new Random().Next(minVal,maxVal +1);
    return newArr;        
}
void Print2dArray (int [,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
       for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j]+ " ");
    Console.WriteLine();
    }
Console.WriteLine();
}

void Matrix (int [,] firstArr, int [,]secondArr)
{
    int size = 2;
    int[,]newArr = new int [size,size];
    int m = 0;
    int n = 0;
    for(int i = 0; i < firstArr.GetLength(0); i++)
    {
       for(int j = 0; j < firstArr.GetLength(1); j++)
        for(int b =0; b< secondArr.GetLength(1); b++)
            for(int a =0; a<secondArr.GetLength(0); a++)
                newArr[m, n] += firstArr[i,j]*secondArr[a,b];
                Console.Write(newArr[m,n]+ " ");
            
    Console.WriteLine();
    }
Console.WriteLine();
}


int [,]firstArr = NewRandom2dArr();
Print2dArray(firstArr);
int [,]secondArr = NewRandom2dArr();
Print2dArray(secondArr);
Matrix(firstArr, secondArr);
*/






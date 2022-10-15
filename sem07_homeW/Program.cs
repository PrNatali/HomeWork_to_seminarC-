// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
/*
double [,] NewRandom2dArray()
{
    Console.Write("enter quantity of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("enter quantity of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("enter of value minimal: ");
    int minVal = Convert.ToInt32(Console.ReadLine());
    Console.Write("enter of value maximal: ");
    int maxVal = Convert.ToInt32(Console.ReadLine());

    double [,] myArr = new double[rows, columns];
    
    for(int i = 0; i < rows; i++)
        for(int j = 0; j < columns; j++) 
             myArr[i,j] = new Random().Next(minVal, maxVal + 1) + new Random().NextDouble();
    
    return myArr;

}

void Print2dArray (double [,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
       for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(Math.Round(array[i,j], 3) + " ");
    Console.WriteLine();
    }
Console.WriteLine();
}

double[,]newArray = NewRandom2dArray();
Print2dArray(newArray);

*/
//Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
/*
int [,] NewRandom2dArr ()
{
    Console.Write("enter quantity of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("enter quantity of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("enter of value minimal: ");
    int minVal = Convert.ToInt32(Console.ReadLine());
    Console.Write("enter of value maximal: ");
    int maxVal = Convert.ToInt32(Console.ReadLine());

    int [,] newArr = new int [rows, columns];

    for (int i = 0; i < rows; i++)
        for(int j = 0; j < columns; j++)
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
void PrintValue (int[,]array)
{
    Console.Write("enter the row of the element: ");
    int x = Convert.ToInt32(Console.ReadLine());
    Console.Write("enter the column of the element: ");
    int y = Convert.ToInt32(Console.ReadLine());
    for(int i = 0; i < array.GetLength(0); i++)
    {
      for(int j = 0; j < array.GetLength(1); j++)
      {
        if(i==(x - 1) && j==(y - 1)) Console.WriteLine(array[i,j]);
        //else Console.WriteLine("dont of the number");
        if((x > array.GetLength(0)) || (y > array.GetLength(1))) 
            Console.WriteLine("dont there number");
      }
        
        Console.WriteLine();
    } 

}

int[,]myArray = NewRandom2dArr();
Print2dArray(myArray);
PrintValue(myArray);
*/

//Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

int [,] NewRandom2dArr ()
{
    Console.Write("enter quantity of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("enter quantity of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("enter of value minimal: ");
    int minVal = Convert.ToInt32(Console.ReadLine());
    Console.Write("enter of value maximal: ");
    int maxVal = Convert.ToInt32(Console.ReadLine());

    int [,] newArr = new int [rows, columns];

    for (int i = 0; i < rows; i++)
        for(int j = 0; j < columns; j++)
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
void AverageColumns(int[,]myArr)
{
    double sum = 0;
    double average = 0;
    for(int j = 0; j< myArr.GetLength(1) ; j++)
    {
        for(int i = 0; i< myArr.GetLength(0); i++)
        {    
            sum += myArr[i,j];
            average = sum / myArr.GetLength(1);
        }
        Console.Write(Math.Round(average , 3) + "\t");
        sum = 0;
    }
}
int [,]newArr = NewRandom2dArr();
Print2dArray(newArr);
AverageColumns(newArr);


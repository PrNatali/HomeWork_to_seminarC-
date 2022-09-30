//Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
/*
int [] NewRandomArray(int x)
{
    int[]newArr = new int [x];
    for(int i =0; i < x; i++)
        newArr[i] = new Random().Next(100, 1000);
    return newArr;    
}
void PrintArray (int[]b)
{
    for(int i = 0; i < b.Length; i++)
        Console.Write(b[i] + " ");
    Console.WriteLine();    
}
int QuantityEvenNum (int[]arr)
{int count = 0;   
    for(int i = 0; i < arr.Length; i++)
    {
    if(arr[i] % 2 == 0)
        count ++;
    }    
return count;      
} 
Console.Write("Enter size the array: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
int[]newArr = NewRandomArray(size); 
PrintArray(newArr);
Console.WriteLine($"Quantity even numbers in the array = {QuantityEvenNum(newArr)}");
*/

//Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
/*
int[] CreateArray (int size, int minVal, int maxVal)
{
int[] myArr = new int[size];
for(int i = 0; i < size; i++)
    myArr[i] = new Random().Next(minVal, maxVal+1);
return myArr; 
}
void PrintArray(int[]myArr)
{
    for(int i = 0; i < myArr.Length; i++)
        Console.Write(myArr[i] + " ");
    Console.WriteLine();    
}   
int FindSumUneven(int[]x)
{
    int count = 0;
    for(int i = 0; i < x.Length; i+=2)
    count += x[i];
return count;    
}
Console.Write("enter size the array: ");
int size = Convert.ToInt32(Console.ReadLine());

Console.Write("enter minimal value the array: ");
int min = Convert.ToInt32(Console.ReadLine());

Console.Write("enter maximal value the array: ");
int max = Convert.ToInt32(Console.ReadLine());

int[]newArray = CreateArray(size, min, max);
PrintArray(newArray);
Console.WriteLine($"sum unevent numbers in the array = {FindSumUneven(newArray)}");
*/

//Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

double[] CreateArray (int size, int minVal, int maxVal)
{
double[] myArr = new double[size];
for(int i = 0; i < size; i++)
    myArr[i] = new Random().Next(minVal, maxVal+1) + new Random().NextDouble();
return myArr; 
}
void PrintArray(double[]myArr)
{
    for(int i = 0; i < myArr.Length; i++)
        Console.Write(myArr[i] + " ");
    Console.WriteLine();    
}   
void FindMaxMin(double[]array)
{   double max = 0;
    double min = 0;
    for(int i = 0; i < array.Length; i ++)  
    {
        if(array[i] > max) max = array[i];
        if(array[i] < min) min = array[i];
    }
    double result = max - min;
Console.WriteLine($"result = {result}");
}
 
Console.Write("enter size the array: ");
int size = Convert.ToInt32(Console.ReadLine());

Console.Write("enter minimal value the array: ");
int min = Convert.ToInt32(Console.ReadLine());

Console.Write("enter maximal value the array: ");
int max = Convert.ToInt32(Console.ReadLine());

double[]newArray = CreateArray(size, min, max);
PrintArray(newArray);
FindMaxMin(newArray);







 
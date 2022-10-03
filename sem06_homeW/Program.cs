//Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь
int [] MyArr(int size)
{
    int[] myArr = new int[size];
    
    for(int i = 0; i < size; i++)
    {
        Console.Write("enter mumber: ");
        myArr[i] = Convert.ToInt32(Console.ReadLine());
        
    }
    return myArr;
}    
void PrintArray(int[]arr)
{
    for(int i = 0; i < arr.Length; i++)
        Console.Write(arr[i]+ " ");
    Console.WriteLine();    
}
int QuantPositiveNum(int[]arr)
{
    int result = 0;
    for(int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0)
            result ++;
    } 
    return result;        
}

Console.WriteLine("enter quantity number  = ");
int len = Convert.ToInt32(Console.ReadLine());
int[]xx = MyArr (len);
PrintArray(xx);
Console.WriteLine($"quantity positive numbers = {QuantPositiveNum(xx)}");



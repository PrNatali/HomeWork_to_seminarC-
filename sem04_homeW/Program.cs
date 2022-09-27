int Pow(int a, int b)
{
    int result = a;
    for(int cur = 1; cur < b; cur ++)
        result *= a;
    return result;           
}

Console.WriteLine("enter number");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("enter power to the number");
int y = Convert.ToInt32(Console.ReadLine());
int res = Pow(x, y);
Console.WriteLine(res);





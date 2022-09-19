// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
/*
void Palindrome(int number)
{
    int result = 0;
    int x = number;
    while (x > 0)
    {
        int secondnum = x % 10;
        result = result * 10 + secondnum;
        x = x / 10;
    }
    if (number == result)
        Console.WriteLine($"number {number} is palindrome");
    else
        Console.WriteLine($"number {number} dont palindrome");   
}

Console.WriteLine("enter the number");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();
Palindrome(a);
*/

//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
/*
double LinghtBetweenPoints(double xa, double ya, double za, double xb, double yb, double zb)
{
    double lx = xa - xb;
    double ly = ya - yb;
    double lz = za - zb;
    double linght = Math.Sqrt(lx*lx + ly*ly + lz*lz);
    return linght;  
}

Console.Write("Enter first x coordinate: ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter first y coordinate: ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter first z coordinate: ");
double z1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter second x coordinate: ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter second y coordinate: ");
double y2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter second z coordinate: ");
double z2 = Convert.ToDouble(Console.ReadLine());

double result = LinghtBetweenPoints(x1, y1, z1, x2, y2, z2);
Console.WriteLine($"segment lenght = {result}");
*/

//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
/*
void NumberCubed (int num)
{
    int x = 1;
    while (x <=num)
    {
        int cubed = x * x * x;
        Console.WriteLine($"cube from number {x} = {cubed}");
        x ++ ;
    }
}

Console.Write("number enter: ");
int n = Convert.ToInt32(Console.ReadLine());
NumberCubed(n);
*/

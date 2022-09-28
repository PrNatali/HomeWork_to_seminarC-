/*

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
Console.WriteLine($"number {x} to the power {y} = {res}");

*/

//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
/*
void SumDigits(int x)
{
    int sum = 0;
   // for(int a = x % 10; x > 0; x = x / 10)
   // c for некорректно считает, не совсем понимаю в чем разница
   while (x > 0)
   {
        int a = x % 10;
        x /= 10;
        sum += a;
   }
    //sum += a;
Console.WriteLine($"summa of digits = {sum}");   
}
Console.WriteLine("enter the number");
int num = Convert.ToInt32(Console.ReadLine());
SumDigits(num);
*/

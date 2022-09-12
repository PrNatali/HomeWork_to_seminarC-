// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
/*
int SecondDigit (int x)
{
    int num, result;

    num = x / 10;
    result = num % 10;
    return result;
}

Console.WriteLine("enter a three-digit number: ");
int a = Convert.ToInt32(Console.ReadLine());
int digit = SecondDigit(a);

Console.WriteLine($"{a}-> {digit}");
*/

//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

void ThirdDigit(int x)
{
    if (x > 100)
    
    {
        while (x > 999)
        {
            x / 10;
        }
        int result = x % 10;
        Console.WriteLine($"{x}-> {result}");
    }
    
    else Console.WriteLine("no third digit");
}

Console.WriteLine("enter the number: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();
ThirdDigit(num);

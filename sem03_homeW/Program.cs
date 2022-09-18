// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

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

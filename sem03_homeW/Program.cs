// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

void Palindrome(int number)
{
    int result = 0;
    while (number > 0)
    {
        int secondnum = number % 10;
        result = result * 10 + secondnum;
        number = number / 10;
    }
    if (number == result)
        Console.WriteLine("number is palindrome");
    else
        Console.WriteLine("dont palindrome");   
}

Console.WriteLine("enter the number");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();
Palindrome(x);

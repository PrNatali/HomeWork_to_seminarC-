//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
/*

Console.Write("input second integer number: ");
int b = Convert.ToInt32(Console.ReadLine());
int max = 0;

if (a > b)
{
    max = a;
}
else 
{
    max = b;
}
Console.WriteLine($"a= {a}; b= {b} -> max = {max}");
*/

//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
/*
Console.Write("input first integer number: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("input second integer number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

Console.Write("input third integer number: ");
int num3 = Convert.ToInt32(Console.ReadLine());

int max = num1;

if (num2 > max)
{
    max = num2;
}
if (num3 > max)
{
    max = num3;
}
Console.WriteLine($"{num1}, {num2}, {num3} -> {max}");
*/
//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
/*
Console.Write("input integer number: ");
int a = Convert.ToInt32(Console.ReadLine());

int remainder = a % 2;

if(remainder == 0)
{
    Console.WriteLine("yes, even");
}
else
{
    Console.WriteLine("not even");
}
*/
//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
/*
Console.Write("input integer number: ");
int a = Convert.ToInt32(Console.ReadLine());

int current = 2;
int step = 2;

while(current <= a)
{
    Console.Write(current + " ");
    current += step;
}
*/
//Павел, благодарю за семинар! Вы лучший преподаватель))
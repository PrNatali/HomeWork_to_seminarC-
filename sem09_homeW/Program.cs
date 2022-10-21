
// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
/*
void ShowDigits (int m, int n)
{
    Console.Write (m + " ");
    if (m > n ) ShowDigits(m -1, n);
}
Console.WriteLine("Enter first digit: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter second digit: ");
int b = Convert.ToInt32(Console.ReadLine());
if(a == b)
Console.WriteLine("Digits equal");
if (a > b) ShowDigits(a,b);
else ShowDigits(b,a);

*/

//  Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
/*
int SumFromNumToNum (int m, int n)
{
    if (m < n -1) return SumFromNumToNum(m +1, n) + m;
    else return m + n;
}

Console.WriteLine("Enter first digit: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter second digit: ");
int b = Convert.ToInt32(Console.ReadLine());
if(a == b)
Console.WriteLine("Digits equal");
if (a < b) 
Console.WriteLine($"summa numbers from {a} to {b} = {SumFromNumToNum(a,b)}");
else 
Console.WriteLine($"summa numbers from {b} to {a} = {SumFromNumToNum(b,a)}");

*/

//Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

void FunAckerman (int a, int b)
{
    if(a == 0) Console.WriteLine(b +1);
    if(a == 1) Console.WriteLine(b+2);
    if(a == 2) Console.WriteLine(2*b+3);
    else 
    Console.WriteLine(Math.Pow(2,b+3)-3);
}


FunAckerman(2,3);
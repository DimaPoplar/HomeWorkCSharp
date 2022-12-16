/*
Задача 64: Задайте значение N. Напишите программу, которая 
выведет все натуральные числа в промежутке от N до 1. 
Выполнить с помощью рекурсии.
*/
Console.WriteLine("Введите число: ");
int N = int.Parse(Console.ReadLine()!);
Console.WriteLine(printNum(N));
string printNum(int N)
{
    if (N == 1)
    {
        return N.ToString();
    }
    else
    {
        return (N + " " + printNum(N - 1));
    }
}
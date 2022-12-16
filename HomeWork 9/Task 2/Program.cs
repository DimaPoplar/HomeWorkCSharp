/*
Задача 66: Задайте значения M и N. Напишите программу, которая найдёт 
сумму натуральных элементов в промежутке от M до N.
*/
Console.Write("Введите число от: ");
int M = int.Parse(Console.ReadLine()!);
Console.Write("Введите число до: ");
int N = int.Parse(Console.ReadLine()!);
Console.WriteLine(SumNum(M,N));

int SumNum(int M, int N)
{
    int Sum = 0;
    if (M == N)
    {
        return M;
    }
    else
    {
        return Sum = M + SumNum(M + 1, N);
    }
}
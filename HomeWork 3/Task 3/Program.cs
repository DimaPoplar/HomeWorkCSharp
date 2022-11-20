/*
Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
*/

Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine()!);
for (int ind = 1; ind < num + 1; ind++)
{
    if (ind == num) Console.Write($"{Math.Pow(ind,2)}.");
    else Console.Write($"{Math.Pow(ind,2)}, ");
}


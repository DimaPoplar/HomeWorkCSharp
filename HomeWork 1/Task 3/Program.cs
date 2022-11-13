/*
Задача 6: Напишите программу, которая на вход принимает число и выдаёт, 
является ли число чётным (делится ли оно на два без остатка).
*/

Console.Write("Напишите число, для проверки его чётности - ");
int num = int.Parse(Console.ReadLine()!);

// double num = double.Parse(Console.ReadLine()!); 

int x = num % 2;
if (x == 0)
{
    Console.WriteLine($"Число {num} чётное.");
}
else
{
    Console.WriteLine($"Число {num} нечётное.");
}
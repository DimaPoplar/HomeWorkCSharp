/*
Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
*/

Console.WriteLine("Для сравнения напишите 3 чила");
Console.Write("Первое число = ");
int num1 = int.Parse(Console.ReadLine()!);
Console.Write("Второе число = ");
int num2 = int.Parse(Console.ReadLine()!);
Console.Write("Третье число = ");
int num3 = int.Parse(Console.ReadLine()!);

// 1 ВАРИАНТ
/*
if (num1 > num2)
{
    if (num1 > num3)
    {
        Console.WriteLine($"max = {num1}");
    }
    else
    {
        Console.WriteLine($"max = {num3}");
    }
}
else 
{
    if (num2 > num3) Console.WriteLine($"max = {num2}");
    if (num3 > num2) Console.WriteLine($"max = {num3}");
}
*/

// 2 ВАРИАНТ
/*
int [] nee = { num1, num2, num3 };
int ord = 0;
int max = 0;
while (max < 3)
{
    if (nee[max] > nee[ord]) 
    {
        ord = max;
        max++;
    }
    else
    {
        max++;
    }
}
Console.WriteLine($"max = {nee[ord]}");
*/
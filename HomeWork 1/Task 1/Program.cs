/* 
Задача 2: 
Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.  
*/

Console.WriteLine("Напишите 2 числа для сравнения");
Console.Write("Напишите 1 число, ");
int num1 = int.Parse(Console.ReadLine()!);
Console.Write("Напишите 2 число, ");
int num2 = int.Parse(Console.ReadLine()!); 

// double num2 = double.Parse(Console.ReadLine()!); 

if (num1 > num2)
{
    Console.WriteLine($"{num1}>{num2} - {num1} больше чем {num2}");
    Console.WriteLine($"max = {num1}, min = {num2}");
}
else
{
    Console.WriteLine($"{num2}>{num1} - {num2} больше чем {num1}");
    Console.WriteLine($"max = {num2}, min = {num1}");
}
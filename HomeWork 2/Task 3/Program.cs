/*
Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую 
день недели, и проверяет, является ли этот день выходным. Обязательна проверка на ввод числа <1 и >7
*/

Console.Write("Введите цифру, обозначающую день недели: ");
int num = int.Parse(Console.ReadLine()!);
if (num >= 1 && num <= 7)
{
    if (num <= 5)
    {
        Console.WriteLine("Это не выходной день!");
    }
    else
    {
        Console.WriteLine("Это выходной день!");
    }
}
else
{
    Console.WriteLine("Такого дня нету!");
}
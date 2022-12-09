/*
Задача 50. Напишите программу, которая на вход
принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, 
что такого элемента нет.
*/

int[,] mass = NewMass(4, 4, 0, 11);
PrintMass(mass);
Console.WriteLine("Введите номер строки: ");
int i = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите номер столбца: ");
int j = int.Parse(Console.ReadLine()!);
if (i <= mass.GetLength(0) - 1 && j <= mass.GetLength(1) - 1)
{
    Console.WriteLine($"Элемент на данном месте = {FindNum(mass, i, j)}");
}
else
{
    Console.WriteLine("Такого элемента нету");
}


int[,] NewMass(int str, int stlb, int min, int max)
{
    int[,] result = new int[str, stlb];
    for (int i = 0; i < str; i++)
    {
        for (int j = 0; j < stlb; j++)
        {
            result[i, j] = new Random().Next(min, max);
        }
    }
    return result;
}
void PrintMass(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

int FindNum(int[,] array, int i, int j)
{
    int result = array[i, j];
    return result;
}

/*
Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая 
будет находить строку с наименьшей суммой элементов.
*/
int[,] mass = NewMass(4, 4, 0, 11);
PrintMass(mass);
Console.WriteLine();
Console.WriteLine($"Строка с минимальной суммой элементов - {MinStr(mass)}");

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

int MinStr(int[,] array)
{
    int minI = 0;
    int[,] result = new int[array.GetLength(0), 1];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int temp = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            temp = temp + array[i, j];
        }
        result[i, 0] = temp;
    }
    for (int i = 0; i < result.GetLength(0); i++)
    {
        int min = result[0, 0];
        if (min > result[i, 0])
        {
            min = result[i, 0];
            minI = i+1;
        }
    }
    return minI;
}
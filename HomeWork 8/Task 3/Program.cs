/*
Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
*/

int[,] mass = NewMass(3, 2, 0, 11);
PrintMass(mass);
Console.WriteLine();
int[,] mass1 = NewMass(2, 2, 0, 11);
PrintMass(mass1);
Console.WriteLine();
if ( mass.GetLength(1) == mass1.GetLength(0))
{
PrintMass(MultMass(mass, mass1));
}
else
{
    Console.WriteLine("Кол-во столбцов 1 массива должно быть равно кол-ву строк 2 массива");
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

int[,] MultMass(int[,] array1, int[,] array2)
{
    int[,] result = new int[array1.GetLength(0), array2.GetLength(1)];
    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int j = 0; j < array2.GetLength(1); j++)
        {
            for (int k = 0; k < array1.GetLength(1); k++)
            {
                result[i, j] += array1[i,k] * array2[k,j];
            }
        }
    }
    return result;
}
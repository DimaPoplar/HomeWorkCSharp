/*
Напишите программу, которая заполнит спирально массив 4 на 4.
*/

Console.WriteLine("Введите кол-во строк: ");
int str = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите кол-во столбцов: ");
int stlb = int.Parse(Console.ReadLine()!);

int[,] mass = NewMass(str, stlb);
PrintMass(mass);

int[,] NewMass(int str, int stlb)
{
    int[,] result = new int[str, stlb];
    int i = 0; int m = 0; int str1 = str - 1;
    int j = 0; int n = 0; int stlb1 = stlb - 1;
    int k = 1;
    int size = str;
    if (size % 2 == 0) size = size / 2;
    else size = size / 2 + 1;

    while (m < size && n < size)
    {
        while (j < stlb1 - n)
        {
            result[i, j] = k;
            j++; k++;
        }
        while (i < str1 - m)
        {
            result[i, j] = k;
            i++; k++;
        }
        while (j != 0 + n)
        {
            result[i, j] = k;
            j--; k++;
        }
        while (i != 1 + m)
        {
            result[i, j] = k;
            i--; k++;
        }
        m++; n++;
    }
    while (j == stlb - n && result[i, j] == 0)
    {
        result[i, j] = k;
        j++; k++;
    }
    while (i == str - m && result[i, j] == 0)
    {
        result[i, j] = k;
        i++; k++;
    }
    while (j != 0 + n && result[i, j] == 0)
    {
        result[i, j] = k;
        j--; k++;
    }
    while (i != 0 + m && result[i, j] == 0)
    {
        result[i, j] = k;
        i--; k++;
    }
    return result;
}

void PrintMass(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write("{0,4}", array[i, j]);
        }
        Console.WriteLine();
    }
}
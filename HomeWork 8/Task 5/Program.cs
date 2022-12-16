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
    int i = 0;
    int j = 0;
    int k = 1; int score = 0;
    int size = str;
    for (int m = 0; m <= size; m++)
    {
        for (score = 0; score < size - 1; score++) result[i, j++] = k++;
        for (score = 0; score < size - 1; score++) result[i++, j] = k++;
        for (score = 0; score < size - 1; score++) result[i, j--] = k++;
        for (score = 0; score < size - 1; score++) result[i--, j] = k++;
        ++i; ++j;
        size = size - 2;
    }
    if (size % 2 != 0)
    {
        result[i, j] = k;
    }
    return result;
}
void PrintMass(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < 10)
            {
                Console.Write("0" + array[i, j]);
                Console.Write(" ");
            }
            else Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

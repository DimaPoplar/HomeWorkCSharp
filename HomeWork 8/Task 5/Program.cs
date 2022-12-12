/*
Напишите программу, которая заполнит спирально массив 4 на 4.
*/

string[,] mass = NewMass(4, 4);
PrintMass(mass);

string[,] NewMass(int str, int stlb)
{
    string[,] result = new string[str, stlb];
    int i = 0;
    int j = 0;
    
    for (j = 0; j < stlb; j++)
    {
        result[i, j] = Convert.ToString(i) + Convert.ToString(j + 1);
    }
    for (i = 1; i < str; i++)
    {
        result[i, j - 1] = Convert.ToString(i - i) + Convert.ToString(j + i);
    }
    int k = 0;
    for (j = j - 1; j > 0; j--)
    {
        result[i - 1, j] = Convert.ToString(i - i) + Convert.ToString(j + i+ k);
        k= k + 2;
    }
    for (i = 0; i > 0; i--)
    {
        result[i - 1, j] = Convert.ToString(1) + Convert.ToString(j);
    }
    for (j = 0; j < 3; j++)
    {
        result[i, j] = Convert.ToString(1) + Convert.ToString(j);
    }
    return result;
}


void PrintMass(string[,] array)
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

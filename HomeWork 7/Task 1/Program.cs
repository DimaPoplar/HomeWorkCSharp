/*
Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
*/
double[,] mass = NewMass(4, 4, 0, 11);
PrintMass(mass);

double[,] NewMass(int str, int stlb, int min, int max)
{
    double[,] result = new double[str, stlb];
    for (int i = 0; i < str; i++)
    {
        for (int j = 0; j < stlb; j++)
        {
            double vr = new Random().Next(1, 10);
            double time = new Random().Next(0, 3);
            result[i, j] = vr / (Math.Pow(10,time));
        }
    }
    return result;
}
void PrintMass(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}\t");
        }
        Console.WriteLine();
    }
}

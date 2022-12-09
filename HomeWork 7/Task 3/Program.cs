/*
Задача 52. Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце.
*/
double[,] mass = NewMass(4, 4, 0, 11);
PrintMass(mass);
PrintMass(SrAr(mass));

double[,] NewMass(int str, int stlb, int min, int max)
{
    double[,] result = new double[str, stlb];
    for (int i = 0; i < str; i++)
    {
        for (int j = 0; j < stlb; j++)
        {
            result[i, j] = new Random().Next(min,max);
        }
    }
    return result;
}
void PrintMass(double[,] array)
{
    double[,] result = new double[array.GetLength(0), 1];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        double temp = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            temp = temp + array[i, j];
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine($"= {result[i, 0] = temp / array.GetLength(1)}");
    }
}

// double[,] SrAr(double[,] array)
// {
//     double[,] result = new double[array.GetLength(0), 1];
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         double temp = 0;
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             temp = temp + array[i, j];
//         }
//         result[i, 0] = temp / array.GetLength(1);
//     }
//     return result;
// }
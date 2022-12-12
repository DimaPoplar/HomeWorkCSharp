/*
Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, 
которая будет построчно выводить массив, добавляя индексы каждого элемента.
*/

int[,,] mass = NewMass(2, 2, 2, 0, 11);
PrintMass(mass);
Console.WriteLine();

int[,,] NewMass(int Ox, int Oy, int Oz, int min, int max)
{
    int[,,] result = new int[Ox, Oy, Oz];
    for (int i = 0; i < Ox; i++)
    {
        for (int j = 0; j < Oy; j++)
        {
            for (int k = 0; k < Oz; k++)
                result[i, j, k] = new Random().Next(min, max);
        }
    }
    return result;
}
void PrintMass(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i, j, k]} {(i,j,k)} ");
            }
            Console.WriteLine();
        }
    }
}
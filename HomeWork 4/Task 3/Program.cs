/*
Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. (числа берете любые)
*/

Console.WriteLine($"Массив - [{String.Join(", ", (NewMass(8)))}]");

int[] NewMass(int size)
{
    int[] mass = new int[size];
    for (int i = 0; i < size; i++)
    {
        mass[i] = new Random().Next(1, 100);
    }
    return mass;
}
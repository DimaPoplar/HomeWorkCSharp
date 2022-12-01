/*
Задача 43: Написать программу, которая на вход принимает массив из 
любого количества элементов (не менее 6)в промежутке от 0 до 100, 
а на выходе выводит этот же массив, но отсортированный 
по возрастанию(от меньшего числа к большему).
*/
int[] Mass = FullArray(10);
Console.WriteLine($"Массив - [{String.Join(", ", Mass)}]");
Console.WriteLine($"Отсортированный массив - [{String.Join(", ", SortMass(Mass))}]");
int[] FullArray(int size)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(0,101);
    }
    return result;
}

int[] SortMass(int[] mass)
{
    int[] result = new int[mass.Length];
    for (int i = 0; i < mass.Length; i++)
    {
        for (int j = 0; j + i < mass.Length; j++)
        {
            if(mass[i] > mass[i + j]) {
            int temp = mass[i];
            mass[i] = mass[j + i];
            mass[j + i] = temp;
            }
            result[i] = mass[i];
        }
    }
    return result;
}
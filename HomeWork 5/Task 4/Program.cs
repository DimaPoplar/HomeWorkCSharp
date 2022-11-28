/*
Задача 38: Задайте массив целых чисел от -10 до 10. 
Найдите разницу между максимальным и минимальным элементов массива.
*/

Console.Write("Введите размер массива: ");
int A = int.Parse(Console.ReadLine()!);

int[] mass1 = NewMass(A);
Console.WriteLine($"[{String.Join(", ", (mass1))}]");
Console.WriteLine($"Разница между min и max элементами = {MinMax(mass1)}");

int[] NewMass(int size)
{
    int[] mass = new int[size];
    for (int i = 0; i < size; i++)
    {
        mass[i] = new Random().Next(-10, 10);
    }
    return mass;
}

int MinMax(int[] mass)
{
    int max = 0;
    int min = 0;
    for (int i = 0; i < mass.Length; i++)
    {
        if (mass[i] > max) max = mass[i];
        if (mass[i] < min) min = mass[i];
    }
    int result = max - min;
    return result;
}
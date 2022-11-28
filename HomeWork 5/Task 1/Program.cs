/*
Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
Напишите программу, которая покажет количество чётных чисел в массиве.
*/
Console.Write("Введите размер массива: ");
int A = int.Parse(Console.ReadLine()!);
int[] mass1 = NewMass(A);
Console.WriteLine($"[{String.Join(", ", (mass1))}]");
Console.WriteLine($"Кол-во чётных чисел = {chet(mass1)}");
int[] NewMass(int size)
{
    int[] mass = new int[size];
    for (int i = 0; i < size; i++)
    {
        mass[i] = new Random().Next(100, 1000);
    }
    return mass;
}

int chet(int[] mass)
{
    int count = 0;
    for (int i = 0; i < mass.Length; i++)
    {
        if (mass[i] % 2 == 0)
        {
            count = count + 1;
        }
    }
    return count;
}
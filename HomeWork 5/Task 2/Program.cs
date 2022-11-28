/*
Задача 36: Задайте одномерный массив, заполненный случайными числами.
Найдите сумму элементов, стоящих на нечётных позициях(индексы элементов должны быть нечетными(1,3,5 и тд)).
*/
Console.Write("Введите размер массива: ");
int A = int.Parse(Console.ReadLine()!);

int[] mass1 = NewMass(A);
Console.WriteLine($"[{String.Join(", ", (mass1))}]");
Console.WriteLine($"Сумма нечётных элементов = {SumNum(mass1)}");

int[] NewMass(int size)
{
    int[] mass = new int[size];
    for (int i = 0; i < size; i++)
    {
        mass[i] = new Random().Next(-10, 11);
    }
    return mass;
}
int SumNum (int[] mass)
{
    int sum = 0;
    for (int i = 0; i < mass.Length; i++)
    {
        if(i % 2 != 0) sum = sum + mass[i];
    }
    return sum;
}
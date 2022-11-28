/*
Задача 37: Найдите произведение пар чисел в одномерном массиве. 
Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
*/
Console.Write("Введите размер массива: ");
int A = int.Parse(Console.ReadLine()!);

int[] mass1 = NewMass(A);
Console.WriteLine($"[{String.Join(", ", (mass1))}]");
int[] mass2 = ParSum(mass1);
Console.WriteLine($"[{String.Join(", ", (mass2))}]");
int[] NewMass(int size)
{
    int[] mass = new int[size];
    for (int i = 0; i < size; i++)
    {
        mass[i] = new Random().Next(0, 21);
    }
    return mass;
}

int[] ParSum(int[] mass)
{
    if (A % 2 == 0)
    {
        int[] newmass = new int[A / 2];
        for (int i = 0; i < newmass.Length; i++)
        {
            if (i < mass.Length - i - 1) newmass[i] = mass[i] * mass[mass.Length - i - 1];
        }
        return newmass;
    }
    else
    {
        int[] newmass1 = new int[A / 2 + 1];
        for (int i = 0; i < newmass1.Length; i++)
        {
            if (i != mass.Length - i - 1) newmass1[i] = mass[i] * mass[mass.Length - i - 1];
            else {
                newmass1[i] = mass[i];
            }
        }
        return newmass1;
    }
}


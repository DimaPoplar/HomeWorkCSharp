/*
Задача 41: Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел строго больше 0 ввёл пользователь.
*/
Console.Write("Сколько чисел нужно проверить? - ");
int M = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Кол-во чисел больше 0 = {CountNum(M)}");
int CountNum(int countM)
{
    int count = 0;
    for (int i = 1; i <= M; i++)
    {
        Console.Write($"Введите {i} число: ");
        int A = int.Parse(Console.ReadLine()!);
        if (A > 0) count++;
    }
    return count;
}

/*
Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
*/

// 1 ВАРИАНТ
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine()!);

int A = DigitNum(num);
Console.WriteLine(DigitNum(num));

Console.WriteLine($"Сумма цифр равна {SumNum(num, A)}");

int DigitNum(int Number)
{
    int count = 0;
    while (Number != 0)
    {
        Number = Number / 10;
        count++;
    }
    return count;
}

int SumNum(int Number, int Count)
{
    int sum = 0;
    int FinalSum = 0;
    for (int i = 0; i < Count; i++)
    {
        sum = Number % 10;
        FinalSum += sum;
        Number = Number / 10;
    }
    return FinalSum;
}

// 2 ВАРИАНТ
/*
Console.Write("Введите число: ");
string num = Console.ReadLine()!;
Console.WriteLine($"Сумма цифр равна {Sum(num)}");

int Sum(string Num)
{
    int sum = 0;
    for (int i = 0; i < Num.Length; i++)
    {
        string A = Convert.ToString(Num[i]);
        int B = Convert.ToInt32(A);
        sum = sum + B;
    }
    return sum;
}
*/
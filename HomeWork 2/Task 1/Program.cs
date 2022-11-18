/*
Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на 
выходе показывает вторую цифру этого числа. 
Обязательна проверка на ввод чисел больше/меньше 3-х знаков
*/
// 1 ВАРИАНТ

Console.Write("Введите 3-х значное число, ");
string num = Console.ReadLine()!;
int num1 = int.Parse(num);
int num2 = num1 * -1;
Console.WriteLine(num1);

if (num.Length == 3)
{
    Console.WriteLine($"Второе число - {num[1]}");
}
else
{
    if (num2 > 99 && num2 < 1000)
    {
        Console.WriteLine($"Второе число - {num[2]}");
    }
    else
    {
        Console.WriteLine("Это не 3-х значное число");
    }
}



// 2 ВАРИАНТ
/*
Console.Write("Введите 3-х значное число, ");
int num = int.Parse(Console.ReadLine());
if (99 < num && num < 1000 || -1000 < num && num < -99)
{
    int two = (num / 10) % 10;
    Console.WriteLine($"Второе число - {two}");
}
else
{
    Console.WriteLine("Это не 3-х значное число");
}
*/
/*
Задача 8: Напишите программу, которая на вход принимает число (N), 
а на выходе показывает все чётные числа от 1 до N.
*/


Console.Write("Напишите число, ");
int num = int.Parse(Console.ReadLine()!);
int score = 1;

// 1 ВАРИАНТ

while (score < num + 1)
{
    if (score % 2 == 0)
    {
        Console.Write($"{score}, ");
    }
    score++;
}


// 2 ВАРИАНТ (Есть точка в конце вывода чисел)
/*
while (score < num + 1)
{
    if (num % 2 == 0)
    {
        if (score % 2 == 0)
        {
            if (score == num) Console.Write($"{num}.");
            else
            {
                Console.Write($"{score}, ");
            }
        }
    }
    else
    {
        if (score % 2 == 0)
        {
            if (score == num - 1) Console.Write($"{num - 1}.");
            else
            {
                Console.Write($"{score}, ");
            }
        }
    }
score++;
}
*/
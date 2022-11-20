/*
Задача 19
Напишите программу, которая принимает на вход пятизначное число
и проверяет, является ли оно палиндромом(первое число равно последнему, второе равно предпоследнему).
*/

Console.Write("Введите 5-ти значное число: ");
// 1 ВАРИАНТ
/*
string num = Console.ReadLine()!;
if (num.Length == 5)
{
    if(num[0] == num[4] && num[1] == num[3]){
        Console.WriteLine("Это палиндром");
    }
    else{
        Console.WriteLine("Это не палиндром");
    }
}
else
{
    Console.WriteLine("Это не 5-ти значное число!");
}
*/

// 2 ВАРИАНТ

int num = int.Parse(Console.ReadLine()!);
if (num > 9999 && num < 100000)
{
    int num1 = num / 10000; int pro = num - num1 * 10000;
    int num2 = pro / 1000; int pro2 = pro - num2 * 1000;
    int pro3 = num % 100; int num4 = pro3 / 10;
    int num5 = num % 10;
    if (num1 == num5 && num2 == num4)
    {
        Console.WriteLine("Это палиндром");
    }
    else
    {
        Console.WriteLine("Это не палиндром");
    }
}
else
{
    Console.WriteLine("Это не 5-ти значное число");
}

/*
Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
что третьей цифры нет. Берем числа до 100000
*/

Console.Write("Введите число: ");
string num = Console.ReadLine()!;
if (num.Length >= 3 && num.Length <= 6)
{
    int num1 = Convert.ToInt32(num);
    if (num1 > num1 * -1)
    {
        Console.WriteLine(num[2]);
    }
    else
    {
        Console.WriteLine(num[3]);
    }

}
else
{
    if (num.Length >= 6)
    Console.WriteLine("Число слишком большое");
    else 
    {
        Console.WriteLine("3-й цифры нет");
    }
}
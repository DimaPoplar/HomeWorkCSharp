/*
Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n.
*/
Console.Write("Введите число M: ");
int n = int.Parse(Console.ReadLine()!);
Console.Write("Введите число N: ");
int m = int.Parse(Console.ReadLine()!);
Console.WriteLine(Aker(n, m));
int Aker(int n, int m)
{
  if (n == 0)
    return m + 1;
  else
    if ((n != 0) && (m == 0))
      return Aker(n - 1, 1);
    else
      return Aker(n - 1, Aker(n, m - 1));
}

/*
Задача 21
Напишите программу, которая принимает на вход координаты 
двух точек и находит расстояние между ними в 3D пространстве.
*/

Console.Write("Введите 1 координату точки A - ");
double Anum = double.Parse(Console.ReadLine()!);
Console.Write("Введите 2 координату точки A - ");
double Anum1 = double.Parse(Console.ReadLine()!);
Console.Write("Введите 3 координату точки A - ");
double Anum2 = double.Parse(Console.ReadLine()!);

Console.Write("Введите 1 координату точки B - ");
double Bnum = double.Parse(Console.ReadLine()!);
Console.Write("Введите 2 координату точки B - ");
double Bnum1 = double.Parse(Console.ReadLine()!);
Console.Write("Введите 3 координату точки B - ");
double Bnum2 = double.Parse(Console.ReadLine()!);

double lon = Math.Sqrt(Math.Pow(Bnum - Anum, 2) + Math.Pow(Bnum1 - Anum1, 2) + Math.Pow(Bnum2 - Anum2, 2));
Console.WriteLine($"Длинна = {lon:f2}");
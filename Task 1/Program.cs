/* Задача 1: Напишите цикл, который принимает на вход два числа
 (A и B) и возводит число A в натуральную степень B. */

Console.Write("Введите число А: ");
string ia = Console.ReadLine();
int a = int.Parse(ia);
Console.Write("Введите число B: ");
string ib = Console.ReadLine();
int b = int.Parse(ib);
int i = 0;
long p = 1;
for (i = 1; i <= b; i++)
{
    p = p * a;
}
Console.Write($"{a} в степени {b} равно {p}");
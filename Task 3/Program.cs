﻿/* Задача 3: Напишите программу, которая задаёт массив из 8 
элементов случайными числами и выводит их на экран. 
Оформите заполнение массива и вывод в виде функции  */
void setArray(int i)
{
    int[] arrA = new int[8];
    //int i = 0;
    for (i = 0; i < 8; i++)
    {
        Random rnd = new Random();
        arrA[i] = rnd.Next(100,1000);
        Console.Write($" {arrA[i]} |");
    }

}
int m = 0;
setArray(m);
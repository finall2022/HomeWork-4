/* Задача 2: Напишите программу, которая принимает на вход число 
и выдаёт сумму цифр в числе. */

Console.Write("Введите число: ");
string istring = Console.ReadLine();
int inum = int.Parse(istring);
int lenght = istring.Length;
int[] arr = new int[lenght];
int index = 0;//lenght - 1;
int sum = 0;
for (index = 0; index < lenght; index++)
{
    arr[index] = inum % 10;
    inum = inum / 10;
    sum = sum + arr[index];
    index = index++;
}
Console.Write($"Сумма цифр числа {istring} равна {sum}");
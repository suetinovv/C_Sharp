﻿// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
int absA = Math.Abs(a); // если число отрицательное
if (absA < 100)
{
    Console.WriteLine($"В числе {a} третьей цифры нет.");
}
else
{
    Console.WriteLine($"В числе {a} третья цифрa {absA.ToString()[2]}");
}
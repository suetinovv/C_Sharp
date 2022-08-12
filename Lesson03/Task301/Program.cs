﻿// Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

int a = 0;
int absA = 0;
while(!(absA > 9999 && absA <= 99999))
{
    Console.WriteLine("Введите пятизначное число: ");
    a = Convert.ToInt32(Console.ReadLine());
    absA = Math.Abs(a); // если число отрицательное
}
if ((absA / 10000 == absA % 10) && ((absA / 1000) % 10 == (absA % 100) / 10))
{
   Console.WriteLine($"Число {a} является палиндромом"); 
}
else
{
    Console.WriteLine($"Число {a} не является палиндромом"); 
}
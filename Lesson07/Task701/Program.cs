﻿// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.WriteLine("Введите количество строк в двухмерном массиве: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов в двухмерном массиве: ");
int n = Convert.ToInt32(Console.ReadLine());

double[,] array = FillArrayRandom(m, n);
PrintArray(array);

double[,] FillArrayRandom(int m, int n) // Возвращает массив заполненый случайными вещественными числами
{
    double[,] array = new double[m, n];
    Random rnd = new Random();
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = Math.Round(rnd.NextDouble(), 1); // в условии не указан диапазон и округление
        }
    }
    return array;
}

void PrintArray(double[,] arr) // выводит двухмерный массив в консоль
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
}
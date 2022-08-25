// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.WriteLine("Введите количество строк в двухмерном массиве: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов в двухмерном массиве: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] array = FillArrayRandom(m, n);
PrintArray(array);
PrintArifmeticColumn(array);

int[,] FillArrayRandom(int m, int n) // Возвращает массив заполненый случайными целыми числами от 1 до 9 включительно
{
    int[,] array = new int[m, n];
    Random rnd = new Random();
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = rnd.Next(1, 10);
        }
    }
    return array;
}

void PrintArray(int[,] arr) // выводит двухмерный массив в консоль
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

void PrintArifmeticColumn(int[,] arr) // выводит среднее арифметическое элементов в каждом столбце
{
    Console.Write("Среднее арифметическое каждого столбца: ");
    for (int i = 0; i < arr.GetLength(1); i++)
    {
        Console.Write($"{GetArifmeticColumn(arr, i)} ");
    }
}

double GetArifmeticColumn(int[,] arr, int column) // возвращает среднее арифметическое столбца
{
    double sum = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        sum += arr[i, column];
    }
    return Math.Round(sum / arr.GetLength(0), 1);
}

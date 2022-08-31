// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int[,] array = new int[,]{
    {1, 4, 8, 2, 9, 5, 3},
    {5, 4, 2, 3, 1, 8, 4},
    {8, 4, 2, 4, 3, 9, 7}
};

PrintArray(array);
Console.WriteLine($"Номер строки с наименьшей суммой элементов: {MinSumLineInArray(array) + 1} строка");

int MinSumLineInArray(int[,] arr) // возвращает индекс строки с минимальной суммой элементов
{
    int indexMinLine = 0;
    int result = SumLine(arr, 0);
    for (int i = 1; i < arr.GetLength(0); i++)
    {
        if (result > SumLine(arr, i))
        {
            indexMinLine = i;
            result = SumLine(arr, i);
        }
    }
    return indexMinLine;
}

int SumLine(int[,] arr, int line) // возвращает сумму элементов строки
{
    int result = 0;
    for (int i = 0; i < arr.GetLength(1); i++)
    {
        result += arr[line, i];
    }
    return result;
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
// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int[,] array = new int[,]{
    {1, 4, 7, 2, 8, 5, 3},
    {5, 9, 2, 3, 1, 8, 4},
    {8, 4, 2, 4, 3, 1, 7}
};

PrintArray(array);
Console.WriteLine();
BubbleSortArray(array);
PrintArray(array);

void BubbleSortArray(int[,] arr) // сортирует массив пузырьковым методом
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        BubbleSortLine(arr, i);
    }
}

void BubbleSortLine(int[,] arr, int line) // сортирует линию в переданом массиве по индексу (пузырьковым методом)
{
    bool isStopped = false;
    while (!isStopped)
    {
        isStopped = true;
        for (int i = 0; i < arr.GetLength(1) - 1; i++)
        {
            if (arr[line, i] < arr[line, i + 1])
            {
                int t = arr[line, i + 1];
                arr[line, i + 1] = arr[line, i];
                arr[line, i] = t;
                isStopped = false;
            }
        }
    }
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
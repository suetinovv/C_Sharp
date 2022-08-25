// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

Console.WriteLine("Введите позицию строки в двухмерном массиве: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите позицию столбца в двухмерном массиве: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[,]{
    {1, 4, 7, 2},
    {5, 9, 2, 3},
    {8, 4, 2, 4}
};

PrintElement(array, m, n);

void PrintElement(int[,] arr, int m, int n) // выводит в консоль значение элемента или информацию об его отсутствии 
{
    if (CheckElementToArray(arr, m, n))
    {
        Console.WriteLine(GetValue(arr, m, n));
    }
    else
    {
        Console.WriteLine("Такого элемента нет");
    }
}

Boolean CheckElementToArray(int[,] arr, int m, int n) // проверяет содержится ли данный элемент в массиве
{
    return m < arr.GetLength(0) && n < arr.GetLength(1);
}

int GetValue(int[,] arr, int m, int n) // возвращает значение элемента из массива
{
    return arr[m, n];
}

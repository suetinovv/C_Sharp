// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] matrixA = new int[,]{
    {2, 4},
    {3, 2}
};

int[,] matrixB = new int[,]{
    {3, 4},
    {3, 3}
};

PrintArray(matrixA);
PrintArray(matrixB);
PrintArray(MatrixMultiplication(matrixA, matrixB));

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
    Console.WriteLine();
}

int[,] MatrixMultiplication(int[,] arrayA, int[,] arrayB)
{
    int[,] resulMatrix = new int[arrayA.GetLength(0), arrayB.GetLength(1)];
    for (int i = 0; i < arrayA.GetLength(0); i++)
    {
        for (int j = 0; j < arrayB.GetLength(1); j++)
        {
            for (int k = 0; k < arrayB.GetLength(0); k++)
            {
                resulMatrix[i, j] += arrayA[i, k] * arrayB[k, j];
            }
        }
    }
    return resulMatrix;
}
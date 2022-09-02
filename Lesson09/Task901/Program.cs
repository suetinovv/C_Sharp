// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5. -> ""1, 2, 3, 4, 5""
// M = 4; N = 8. -> ""4, 6, 7, 8""

Console.Write("Введите натуральное число M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите натуральное число N: ");
int n = Convert.ToInt32(Console.ReadLine());

PrintNumbers(m, n);

void PrintNumbers(int numberM, int numberN)
{
    if (numberM < numberN)
    {
        for (int i = numberM; i <= numberN; i++)
        {
            Console.Write($"{i} ");
        }
    }
    else
    {
        for (int i = numberM; i >= numberN; i--)
        {
            Console.Write($"{i} ");
        }
    }

}
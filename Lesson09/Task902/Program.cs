// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Write("Введите натуральное число M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите натуральное число N: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Сумма натуральных элементов в промежутке от M до N равна: {SumNumbers(m, n)} ");

int SumNumbers(int numberM, int numberN) // возвращает сумму натуральных элементов от M до N
{
    int result = 0;
    if (numberM > numberN)
    {
        int temp = numberM;
        numberM = numberN;
        numberN = temp;
    }
    for (int i = numberM; i <= numberN; i++)
    {
        result += i;
    }
    return result;
}
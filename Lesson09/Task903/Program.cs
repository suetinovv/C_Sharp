// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 29

Console.Write("Введите натуральное число M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите натуральное число N: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write($"Результат работы функции Аккермана: {FunAkkermana(m, n)}");

int FunAkkermana(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0)
    {
        return FunAkkermana(m - 1, 1);
    }
    return FunAkkermana(m - 1, FunAkkermana(m, n - 1));
}
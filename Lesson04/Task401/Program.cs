// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Введите число которое нужно возвести в степень: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число (степень) в которую нужно возвести число: ");
int b = Convert.ToInt32(Console.ReadLine());

PrintPow(a, b);

int Pow(int a, int b)
{
    int result = 1;
    for(int i = 0; i < b; i++)
    {
        result *= a;
    }
return result;
}

void PrintPow(int a, int b)
{
    Console.WriteLine($"Число {a} в степени {b} = {Pow(a, b)}");
}
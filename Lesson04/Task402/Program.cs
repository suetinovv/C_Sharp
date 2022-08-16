// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());

PrintSumNumber(a);

int SumNumber(int a)
{
    int absA = Math.Abs(a); // если число отрицательное
    int result = 0;
    while(absA != 0)
    {
        result += absA % 10;
        absA /= 10;
    }
return result;
}

void PrintSumNumber(int a)
{
    Console.WriteLine($"Сумма цифр в числе {a} равна {SumNumber(a)}");
}
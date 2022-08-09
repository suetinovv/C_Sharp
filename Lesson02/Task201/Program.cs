// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8

int a = 0;
int absA = 0;
while(absA < 100 || absA > 999)
{
    Console.WriteLine("Введите трёхзначное число: ");
    a = Convert.ToInt32(Console.ReadLine());
    absA = Math.Abs(a); // если число отрицательное
}
Console.WriteLine($"В числе {a} вторая цифрa {absA.ToString()[1]}");
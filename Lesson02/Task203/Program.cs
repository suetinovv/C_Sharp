// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

int a = 0;
while(!(a >= 1 && a <= 7))
{
    Console.WriteLine("Введите цифру от 1 до 7 (обозначающую день недели): ");
    a = Convert.ToInt32(Console.ReadLine());
}
if (a >= 1 && a <= 5)
{
    Console.WriteLine($"Цифра {a} не является выходным.");
}
else
{
    Console.WriteLine($"Цифра {a} является выходным.");
}
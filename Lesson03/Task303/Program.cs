// Задача 23 Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

int a = 0;
while(a < 1)
{
    Console.WriteLine("Введите число больше нуля: ");
    a = Convert.ToInt32(Console.ReadLine());
}
for (int i = 1; i <= a; i++)
{
    Console.Write($"{i * i * i} ");
}
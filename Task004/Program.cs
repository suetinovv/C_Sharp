//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

int a = 0;
while(a < 2){
    Console.WriteLine("Введите число больше 2: ");
    a = Convert.ToInt32(Console.ReadLine());
}
Console.Write($"Все четные числа от 1 до {a}: ");
for (int i = 2; i <= a; i += 2){
    Console.Write(i + " ");
}
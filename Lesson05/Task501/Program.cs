// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
// которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int len = 0;
while(len < 1)
{
    Console.WriteLine("Задайте размер массива (размер должен быть больше 0): ");
    len = Convert.ToInt32(Console.ReadLine());
}

int[] arr = RandomArr(len);
PrintChet(arr);

int[] RandomArr(int len)
{
    int[] arr = new int[len];
    Random rnd = new Random();
    for(int i = 0; i < len; i++)
    {
        arr[i] = rnd.Next(100, 1000);
    }
    return arr;
}

void PrintChet(int[] arr)
{
    int count = 0;
    foreach (var i in arr)
    {
        if (i % 2 == 0)
        {
            count++;
        }
    }
    Console.Write("В массиве:[ ");
    foreach (var i in arr)
    {
        Console.Write($"{i} ");
    }
    Console.WriteLine($"] четных чисел: {count}");
}
// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int[] arr = new int[8];
string otvet = "";
while(!(otvet.Equals("n") || otvet.Equals("y")))
{
    Console.WriteLine("Если желаете заполнить массив автоматически, введи 'Y', если желаете заполнить вручную, введите 'N': ");
    otvet = Console.ReadLine().ToLower();
}

PrintArr(otvet, arr);

void RandomArr(int[] arr)
{
    Random rnd = new Random();
    for(int i = 0; i < 8; i++)
    {
        arr[i] = rnd.Next();
    }
}

void NoRandomArr(int[] arr)
{
    for(int i = 0; i < 8; i++)
    {
        Console.WriteLine($"Введите {i + 1} элемент массива: "); //номер элемента для пользователя с 1
        arr[i] = Convert.ToInt32(Console.ReadLine());
    }
}

void PrintArr(string s, int[] a)
{
    if(s.Equals("y"))
    {
        RandomArr(a);
    }
    else
    {
        NoRandomArr(a);
    }
    for(int i = 0; i < 8; i++)
    {
        Console.Write(a[i] + " ");
    }
}
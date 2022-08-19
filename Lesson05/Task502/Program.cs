// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


// нужно предусмотреть ограничение на размер массива и максимальное число в массиве, чтобы не получилось целочисленное переполнение!!!


int len = 0; 
while(len < 2)
{
    Console.WriteLine("Задайте размер массива (размер должен быть больше 1): ");
    len = Convert.ToInt32(Console.ReadLine()); // нужно предусмотреть ограничения размера массива
}

int[] arr = RandomArr(len);
PrintSumChet(arr);

int[] RandomArr(int len)
{
    int[] arr = new int[len];
    Random rnd = new Random();
    for(int i = 0; i < len; i++)
    {
        arr[i] = rnd.Next(); // нужно указать ограничение, можно получить целочисленное переполнение при мазмере массива больше 3
    }
    return arr;
}

void PrintSumChet(int[] arr)
{
    int result = 0; 
    for (int i = 1; i < arr.Length; i += 2)
    {
        result += arr[i];
    }
    Console.Write("В массиве:[ ");
    foreach (var i in arr)
    {
        Console.Write($"{i} ");
    }
    Console.WriteLine($"] сумма элементов, стоящих на нечётных позициях равна: {result}");
}
// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

int len = 0; 
while(len < 2)
{
    Console.WriteLine("Задайте размер массива (размер должен быть больше 1): ");
    len = Convert.ToInt32(Console.ReadLine());
}

double[] arr = RandomArr(len);
PrintMaxMin(arr);



void PrintMaxMin(double[] arr)
{
    Console.Write("В массиве:[ ");
    foreach (var i in arr)
    {
        Console.Write($"{i} ");
    }
    Console.WriteLine($"] разница между максимальным и минимальным элементами массива, равна: {Max(arr) - Min(arr)}");
}

double Max(double[] arr)
{
    double result = arr[0];
    foreach (var i in arr)
    {
        if(result < i)
        {
            result = i;
        }
    }
    return result;
}

double Min(double[] arr)
{
    double result = arr[0];
    foreach (var i in arr)
    {
        if(result > i)
        {
            result = i;
        }
    }
    return result;
}

double[] RandomArr(int len)
{
    double[] arr = new double[len];
    Random rnd = new Random();
    for(int i = 0; i < len; i++)
    {
        arr[i] = rnd.NextDouble(); // в условии не указан диапазон
    }
    return arr;
}
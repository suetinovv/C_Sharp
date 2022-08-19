// Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
// Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

int len = 0; 
while(len < 2)
{
    Console.WriteLine("Задайте размер массива (размер должен быть больше 1): ");
    len = Convert.ToInt32(Console.ReadLine()); // нужно предусмотреть ограничения размера массива
}

int[] arr = RandomArr(len);
int[] arrProizv = ProizvedParArr(arr);

int[] ProizvedParArr(int[] arr)
{
    int len = (arr.Length / 2) + (arr.Length % 2);
    int[] resultArr = new int[len];
    for(int i = 0; i < len; i++)
    {
        resultArr[i] = arr[i] * arr[arr.Length - (i + 1)];
    }
    if(arr.Length % 2 != 0)
    {
        resultArr[len - 1] = arr[len - 1];
    }
    
    // печать результата, можно опустить т.к. в условии не сказано (добавленно для проверки)

    Console.Write("В массиве:[ ");
    foreach (var i in arr)
    {
        Console.Write($"{i} ");
    }
    Console.Write("] произведение крайних элементов согласно условию: ");
    Console.Write("[ ");
    foreach (var i in resultArr)
    {
        Console.Write($"{i} ");
    }
    Console.WriteLine("]");

    return resultArr;
}

int[] RandomArr(int len)
{
    int[] arr = new int[len];
    Random rnd = new Random();
    for(int i = 0; i < len; i++)
    {
        arr[i] = rnd.Next(1, 10); // поставил от 1 до 9 включительно так, как в условии не указано
    }
    return arr;
}
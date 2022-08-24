// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3     <- !!!! условие проверки задание не правельно, правельный ответ 4

List<int> numberList = new List<int>();
string text = string.Empty;

while (!text.ToLower().Equals("exit")) // вводим числа пока не введут exit
{
    Console.Write("Введите число или 'exit' для выходы: ");
    text = Console.ReadLine();
    if (int.TryParse(text, out int number))
    {
        numberList.Add(Convert.ToInt32(text));
        Console.WriteLine($"Вы добавили число {Convert.ToInt32(text)}");
    }
    else
    {
        Console.WriteLine("Не удалось распознать число, попробуйте еще раз.");
    }
}

Print(CheckingPositiveNumbers(numberList));

void Print(int number) // выводит результат в консоль
{
    if (number == 0)
    {
        Console.WriteLine("Вы не ввели числа больше 0");
    }
    else if (number >= 11 && number <= 14)
    {
        Console.WriteLine($"Вы ввели {number} чисел больше 0");
    }
    else if (number % 10 == 1)
    {
        Console.WriteLine($"Вы ввели {number} число больше 0");
    }
    else if (number % 10 < 5)
    {
        Console.WriteLine($"Вы ввели {number} числа больше 0");
    }
    else
    {
        Console.WriteLine($"Вы ввели {number} чисел больше 0");
    }
}

int CheckingPositiveNumbers(List<int> list) // возвращает количество чисел больше нуля
{
    int counter = 0;
    foreach (var number in list)
    {
        if (number > 0)
        {
            counter++;
        }
    }
    return counter;
}
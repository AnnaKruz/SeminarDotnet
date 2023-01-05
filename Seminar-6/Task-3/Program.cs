// **Задача 42:** Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10
string BinaryNumber(int number)
{    
    int var = number;
    string result = string.Empty;
    while (var >0)
    {
        result = $"{var % 2}" + result;
        var = var / 2;
    }
    return result;
}

int GetNumber(string text)
{
    Console.WriteLine(text);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int number = GetNumber("Введите число: ");

Console.WriteLine(BinaryNumber(number));